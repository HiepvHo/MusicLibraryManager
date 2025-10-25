using System;
using System.Collections.Generic;
using System.Linq;
using MusicLibraryManager.Entities;

namespace MusicLibraryManager.Helpers
{
    /// <summary>
    /// Quản lý trạng thái phát nhạc: playlist hiện tại, bài hát đang phát, shuffle, repeat
    /// </summary>
    public static class PlaybackManager
    {
        // Playlist hiện tại
        private static List<Song> currentPlaylist = new List<Song>();
        private static int currentIndex = -1;
        private static bool isShuffleMode = false;
        private static RepeatMode repeatMode = RepeatMode.None;
        private static Random random = new Random();

        // Events để thông báo khi có thay đổi
        public static event EventHandler<Song> OnSongChanged;
        public static event EventHandler<bool> OnShuffleModeChanged;
        public static event EventHandler<RepeatMode> OnRepeatModeChanged;
        public static event EventHandler OnPlaylistChanged;

        /// <summary>
        /// Bài hát đang phát
        /// </summary>
        public static Song CurrentSong
        {
            get
            {
                if (currentIndex >= 0 && currentIndex < currentPlaylist.Count)
                    return currentPlaylist[currentIndex];
                return null;
            }
        }

        /// <summary>
        /// Chế độ shuffle
        /// </summary>
        public static bool IsShuffleMode
        {
            get { return isShuffleMode; }
            set
            {
                isShuffleMode = value;
                OnShuffleModeChanged?.Invoke(null, value);
            }
        }

        /// <summary>
        /// Chế độ repeat
        /// </summary>
        public static RepeatMode CurrentRepeatMode
        {
            get { return repeatMode; }
            set
            {
                repeatMode = value;
                OnRepeatModeChanged?.Invoke(null, value);
            }
        }

        /// <summary>
        /// Có bài hát tiếp theo không
        /// </summary>
        public static bool HasNext
        {
            get
            {
                if (repeatMode == RepeatMode.One)
                    return true;
                if (repeatMode == RepeatMode.All && currentPlaylist.Count > 0)
                    return true;
                return currentIndex < currentPlaylist.Count - 1;
            }
        }

        /// <summary>
        /// Có bài hát trước đó không
        /// </summary>
        public static bool HasPrevious
        {
            get
            {
                if (repeatMode == RepeatMode.One)
                    return true;
                if (repeatMode == RepeatMode.All && currentPlaylist.Count > 0)
                    return true;
                return currentIndex > 0;
            }
        }

        /// <summary>
        /// Set playlist và phát bài hát đầu tiên
        /// </summary>
        public static void SetPlaylist(List<Song> songs, int startIndex = 0)
        {
            currentPlaylist = songs ?? new List<Song>();
            currentIndex = startIndex >= 0 && startIndex < currentPlaylist.Count ? startIndex : 0;
            
            OnPlaylistChanged?.Invoke(null, EventArgs.Empty);
            
            if (CurrentSong != null)
                OnSongChanged?.Invoke(null, CurrentSong);
        }

        /// <summary>
        /// Phát một bài hát cụ thể
        /// </summary>
        public static void PlaySong(Song song)
        {
            if (song == null) return;

            // Tìm bài hát trong playlist hiện tại
            int index = currentPlaylist.FindIndex(s => s.SongID == song.SongID);
            
            if (index >= 0)
            {
                // Có trong playlist, set index
                currentIndex = index;
            }
            else
            {
                // Không có trong playlist, tạo playlist mới với 1 bài
                currentPlaylist = new List<Song> { song };
                currentIndex = 0;
                OnPlaylistChanged?.Invoke(null, EventArgs.Empty);
            }

            OnSongChanged?.Invoke(null, CurrentSong);
        }

        /// <summary>
        /// Chuyển sang bài tiếp theo
        /// </summary>
        public static Song Next()
        {
            if (currentPlaylist.Count == 0)
                return null;

            if (repeatMode == RepeatMode.One)
            {
                // Repeat One: phát lại bài hiện tại
                OnSongChanged?.Invoke(null, CurrentSong);
                return CurrentSong;
            }

            if (isShuffleMode)
            {
                // Shuffle: chọn ngẫu nhiên (trừ bài hiện tại)
                if (currentPlaylist.Count > 1)
                {
                    int newIndex;
                    do
                    {
                        newIndex = random.Next(currentPlaylist.Count);
                    } while (newIndex == currentIndex);
                    currentIndex = newIndex;
                }
            }
            else
            {
                // Normal: next
                currentIndex++;
                
                if (currentIndex >= currentPlaylist.Count)
                {
                    if (repeatMode == RepeatMode.All)
                    {
                        // Repeat All: quay lại đầu
                        currentIndex = 0;
                    }
                    else
                    {
                        // Hết playlist
                        currentIndex = currentPlaylist.Count - 1;
                        return null;
                    }
                }
            }

            OnSongChanged?.Invoke(null, CurrentSong);
            return CurrentSong;
        }

        /// <summary>
        /// Chuyển về bài trước
        /// </summary>
        public static Song Previous()
        {
            if (currentPlaylist.Count == 0)
                return null;

            if (repeatMode == RepeatMode.One)
            {
                // Repeat One: phát lại bài hiện tại
                OnSongChanged?.Invoke(null, CurrentSong);
                return CurrentSong;
            }

            if (isShuffleMode)
            {
                // Shuffle: chọn ngẫu nhiên (trừ bài hiện tại)
                if (currentPlaylist.Count > 1)
                {
                    int newIndex;
                    do
                    {
                        newIndex = random.Next(currentPlaylist.Count);
                    } while (newIndex == currentIndex);
                    currentIndex = newIndex;
                }
            }
            else
            {
                // Normal: previous
                currentIndex--;
                
                if (currentIndex < 0)
                {
                    if (repeatMode == RepeatMode.All)
                    {
                        // Repeat All: quay về cuối
                        currentIndex = currentPlaylist.Count - 1;
                    }
                    else
                    {
                        // Đã ở đầu playlist
                        currentIndex = 0;
                        return null;
                    }
                }
            }

            OnSongChanged?.Invoke(null, CurrentSong);
            return CurrentSong;
        }

        /// <summary>
        /// Toggle shuffle mode
        /// </summary>
        public static void ToggleShuffle()
        {
            IsShuffleMode = !IsShuffleMode;
        }

        /// <summary>
        /// Toggle repeat mode
        /// </summary>
        public static void ToggleRepeat()
        {
            switch (repeatMode)
            {
                case RepeatMode.None:
                    CurrentRepeatMode = RepeatMode.All;
                    break;
                case RepeatMode.All:
                    CurrentRepeatMode = RepeatMode.One;
                    break;
                case RepeatMode.One:
                    CurrentRepeatMode = RepeatMode.None;
                    break;
            }
        }

        /// <summary>
        /// Clear playlist
        /// </summary>
        public static void Clear()
        {
            currentPlaylist.Clear();
            currentIndex = -1;
            OnPlaylistChanged?.Invoke(null, EventArgs.Empty);
        }

        /// <summary>
        /// Lấy toàn bộ playlist hiện tại
        /// </summary>
        public static List<Song> GetCurrentPlaylist()
        {
            return new List<Song>(currentPlaylist);
        }

        /// <summary>
        /// Lấy index hiện tại
        /// </summary>
        public static int GetCurrentIndex()
        {
            return currentIndex;
        }
    }

    /// <summary>
    /// Chế độ repeat
    /// </summary>
    public enum RepeatMode
    {
        None,   // Không repeat
        All,    // Repeat toàn bộ playlist
        One     // Repeat 1 bài
    }
}

