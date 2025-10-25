using System;
using System.Collections.Generic;
using MusicLibraryManager.DAL;
using MusicLibraryManager.Entities;

namespace MusicLibraryManager.BUS
{
    public class PlaylistBUS
    {
        /// <summary>
        /// Lấy tất cả playlist
        /// </summary>
        public static List<Playlist> GetAllPlaylists()
        {
            try
            {
                return PlaylistDAO.GetAllPlaylists();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách playlist: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Lấy playlist theo ID
        /// </summary>
        public static Playlist GetPlaylistByID(int playlistID)
        {
            try
            {
                if (playlistID <= 0)
                    throw new Exception("ID playlist không hợp lệ");

                return PlaylistDAO.GetPlaylistByID(playlistID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy thông tin playlist: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Tạo playlist mới
        /// </summary>
        public static int CreatePlaylist(Playlist playlist)
        {
            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(playlist.PlaylistName))
                    throw new Exception("Tên playlist không được để trống");

                return PlaylistDAO.CreatePlaylist(playlist);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tạo playlist: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Cập nhật playlist
        /// </summary>
        public static bool UpdatePlaylist(Playlist playlist)
        {
            try
            {
                // Validation
                if (playlist.PlaylistID <= 0)
                    throw new Exception("ID playlist không hợp lệ");

                if (string.IsNullOrWhiteSpace(playlist.PlaylistName))
                    throw new Exception("Tên playlist không được để trống");

                return PlaylistDAO.UpdatePlaylist(playlist);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật playlist: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Xóa playlist
        /// </summary>
        public static bool DeletePlaylist(int playlistID)
        {
            try
            {
                if (playlistID <= 0)
                    throw new Exception("ID playlist không hợp lệ");

                return PlaylistDAO.DeletePlaylist(playlistID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa playlist: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Lấy các bài hát trong playlist
        /// </summary>
        public static List<Song> GetPlaylistSongs(int playlistID)
        {
            try
            {
                if (playlistID <= 0)
                    throw new Exception("ID playlist không hợp lệ");

                return PlaylistDAO.GetPlaylistSongs(playlistID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách bài hát: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Thêm bài hát vào playlist
        /// </summary>
        public static bool AddSongToPlaylist(int playlistID, int songID)
        {
            try
            {
                if (playlistID <= 0 || songID <= 0)
                    throw new Exception("ID không hợp lệ");

                return PlaylistDAO.AddSongToPlaylist(playlistID, songID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm bài hát vào playlist: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Xóa bài hát khỏi playlist
        /// </summary>
        public static bool RemoveSongFromPlaylist(int playlistID, int songID)
        {
            try
            {
                if (playlistID <= 0 || songID <= 0)
                    throw new Exception("ID không hợp lệ");

                return PlaylistDAO.RemoveSongFromPlaylist(playlistID, songID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa bài hát khỏi playlist: {ex.Message}", ex);
            }
        }
    }
}

