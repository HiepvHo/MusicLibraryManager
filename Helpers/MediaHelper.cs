using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace MusicLibraryManager.Helpers
{
    /// <summary>
    /// Helper để lấy thông tin từ file media (audio/video)
    /// </summary>
    public static class MediaHelper
    {
        /// <summary>
        /// Lấy thời lượng của file media (tính bằng giây)
        /// </summary>
        public static int? GetMediaDuration(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                return null;

            // Thử method 1: Dùng Windows Media Player (tốt cho cả MP3 và MP4)
            var duration = GetDurationFromWMP(filePath);
            if (duration.HasValue && duration.Value > 0)
                return duration;

            // Thử method 2: Dùng Shell32 (backup cho MP3)
            return GetDurationFromShell32(filePath);
        }

        /// <summary>
        /// Lấy duration từ Windows Media Player (chính xác nhất)
        /// </summary>
        private static int? GetDurationFromWMP(string filePath)
        {
            try
            {
                var player = new WMPLib.WindowsMediaPlayer();
                var media = player.newMedia(filePath);
                
                // Đợi metadata load (tối đa 3 giây)
                int attempts = 0;
                while (media.duration == 0 && attempts < 30)
                {
                    Thread.Sleep(100);
                    attempts++;
                }
                
                double duration = media.duration;
                player.close();
                
                return duration > 0 ? (int)Math.Round(duration) : (int?)null;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Lấy duration từ Shell32 (backup method)
        /// </summary>
        private static int? GetDurationFromShell32(string filePath)
        {
            try
            {
                // Sử dụng Shell32 để đọc metadata
                var shell = new Shell32.Shell();
                var folder = shell.NameSpace(Path.GetDirectoryName(filePath));
                var file = folder.ParseName(Path.GetFileName(filePath));

                // Index 27 là Duration trong Windows metadata
                string duration = folder.GetDetailsOf(file, 27);
                
                if (!string.IsNullOrEmpty(duration))
                {
                    // Parse duration từ format "00:03:45" hoặc "3:45"
                    var parts = duration.Split(':');
                    int totalSeconds = 0;

                    if (parts.Length == 3) // HH:MM:SS
                    {
                        totalSeconds = int.Parse(parts[0]) * 3600 + 
                                      int.Parse(parts[1]) * 60 + 
                                      int.Parse(parts[2]);
                    }
                    else if (parts.Length == 2) // MM:SS
                    {
                        totalSeconds = int.Parse(parts[0]) * 60 + 
                                      int.Parse(parts[1]);
                    }

                    return totalSeconds > 0 ? totalSeconds : (int?)null;
                }

                return null;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Format seconds thành MM:SS hoặc HH:MM:SS
        /// </summary>
        public static string FormatDuration(int? seconds)
        {
            if (!seconds.HasValue || seconds.Value <= 0)
                return "00:00";

            var timeSpan = TimeSpan.FromSeconds(seconds.Value);
            
            if (timeSpan.Hours > 0)
                return timeSpan.ToString(@"hh\:mm\:ss");
            else
                return timeSpan.ToString(@"mm\:ss");
        }

        /// <summary>
        /// Lấy kích thước file (bytes)
        /// </summary>
        public static long? GetFileSize(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                return null;

            try
            {
                var fileInfo = new FileInfo(filePath);
                return fileInfo.Length;
            }
            catch
            {
                return null;
            }
        }
    }
}

