using System;
using System.Collections.Generic;
using System.IO;
using MusicLibraryManager.DAL;
using MusicLibraryManager.Entities;
using MusicLibraryManager.Helpers;

namespace MusicLibraryManager.BUS
{
    public class SongBUS
    {
        /// <summary>
        /// Lấy tất cả bài hát
        /// </summary>
        public static List<Song> GetAllSongs()
        {
            try
            {
                return SongDAO.GetAllSongs(UserSession.CurrentUserID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách bài hát: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Lấy bài hát theo ID
        /// </summary>
        public static Song GetSongByID(int songID)
        {
            try
            {
                if (songID <= 0)
                    throw new Exception("ID bài hát không hợp lệ");

                return SongDAO.GetSongByID(songID, UserSession.CurrentUserID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy thông tin bài hát: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Thêm bài hát mới
        /// </summary>
        public static int AddSong(Song song)
        {
            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(song.SongTitle))
                    throw new Exception("Tên bài hát không được để trống");

                if (string.IsNullOrWhiteSpace(song.FilePath))
                    throw new Exception("Đường dẫn file không được để trống");

                if (!File.Exists(song.FilePath))
                    throw new Exception("File nhạc không tồn tại");

                return SongDAO.AddSong(song, UserSession.CurrentUserID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm bài hát: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Cập nhật bài hát
        /// </summary>
        public static bool UpdateSong(Song song)
        {
            try
            {
                // Validation
                if (song.SongID <= 0)
                    throw new Exception("ID bài hát không hợp lệ");

                if (string.IsNullOrWhiteSpace(song.SongTitle))
                    throw new Exception("Tên bài hát không được để trống");

                return SongDAO.UpdateSong(song, UserSession.CurrentUserID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật bài hát: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Xóa bài hát
        /// </summary>
        public static bool DeleteSong(int songID)
        {
            try
            {
                if (songID <= 0)
                    throw new Exception("ID bài hát không hợp lệ");

                return SongDAO.DeleteSong(songID, UserSession.CurrentUserID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa bài hát: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Tìm kiếm bài hát
        /// </summary>
        public static List<Song> SearchSongs(string searchTerm)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchTerm))
                    return GetAllSongs();

                return SongDAO.SearchSongs(searchTerm.Trim(), UserSession.CurrentUserID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tìm kiếm bài hát: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Cập nhật số lần phát
        /// </summary>
        public static bool UpdatePlayCount(int songID)
        {
            try
            {
                return SongDAO.UpdatePlayCount(songID);
            }
            catch
            {
                return false; // Silent fail for play count
            }
        }

        /// <summary>
        /// Toggle yêu thích
        /// </summary>
        public static bool ToggleFavorite(int songID)
        {
            try
            {
                if (songID <= 0)
                    throw new Exception("ID bài hát không hợp lệ");

                return SongDAO.ToggleFavorite(songID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật yêu thích: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Lấy danh sách bài hát yêu thích
        /// </summary>
        public static List<Song> GetFavoriteSongs()
        {
            try
            {
                return SongDAO.GetFavoriteSongs();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách yêu thích: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Lấy top bài hát được nghe nhiều nhất
        /// </summary>
        public static List<Song> GetTopPlayedSongs(int topCount = 10)
        {
            try
            {
                return SongDAO.GetTopPlayedSongs(topCount);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy top bài hát: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Kiểm tra file nhạc hợp lệ
        /// </summary>
        public static bool IsValidMusicFile(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
                return false;

            // Hỗ trợ cả audio và video files
            string[] validExtensions = { 
                ".mp3", ".wav", ".wma", ".flac", ".m4a", ".aac",  // Audio
                ".mp4", ".avi", ".wmv", ".mkv", ".mov"            // Video
            };
            string extension = Path.GetExtension(filePath).ToLower();

            return Array.Exists(validExtensions, ext => ext == extension);
        }
    }
}

