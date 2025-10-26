using System;
using System.Collections.Generic;
using MusicLibraryManager.DAL;
using MusicLibraryManager.Entities;
using MusicLibraryManager.Helpers;

namespace MusicLibraryManager.BUS
{
    public class ArtistBUS
    {
        /// <summary>
        /// Lấy tất cả ca sĩ
        /// </summary>
        public static List<Artist> GetAllArtists()
        {
            try
            {
                return ArtistDAO.GetAllArtists(UserSession.CurrentUserID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách ca sĩ: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Lấy ca sĩ theo ID
        /// </summary>
        public static Artist GetArtistByID(int artistID)
        {
            try
            {
                if (artistID <= 0)
                    throw new Exception("ID ca sĩ không hợp lệ");

                return ArtistDAO.GetArtistByID(artistID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy thông tin ca sĩ: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Thêm ca sĩ mới
        /// </summary>
        public static int AddArtist(Artist artist)
        {
            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(artist.ArtistName))
                    throw new Exception("Tên ca sĩ không được để trống");

                // Kiểm tra trùng lặp
                List<Artist> existingArtists = ArtistDAO.SearchArtists(artist.ArtistName, UserSession.CurrentUserID);
                if (existingArtists.Exists(a => a.ArtistName.Equals(artist.ArtistName, StringComparison.OrdinalIgnoreCase)))
                    throw new Exception("Ca sĩ này đã tồn tại trong hệ thống");

                return ArtistDAO.AddArtist(artist, UserSession.CurrentUserID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm ca sĩ: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Cập nhật thông tin ca sĩ
        /// </summary>
        public static bool UpdateArtist(Artist artist)
        {
            try
            {
                // Validation
                if (artist.ArtistID <= 0)
                    throw new Exception("ID ca sĩ không hợp lệ");

                if (string.IsNullOrWhiteSpace(artist.ArtistName))
                    throw new Exception("Tên ca sĩ không được để trống");

                return ArtistDAO.UpdateArtist(artist, UserSession.CurrentUserID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật ca sĩ: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Xóa ca sĩ
        /// </summary>
        public static bool DeleteArtist(int artistID)
        {
            try
            {
                if (artistID <= 0)
                    throw new Exception("ID ca sĩ không hợp lệ");

                return ArtistDAO.DeleteArtist(artistID, UserSession.CurrentUserID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa ca sĩ: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Tìm kiếm ca sĩ
        /// </summary>
        public static List<Artist> SearchArtists(string searchTerm)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchTerm))
                    return GetAllArtists();

                return ArtistDAO.SearchArtists(searchTerm.Trim(), UserSession.CurrentUserID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tìm kiếm ca sĩ: {ex.Message}", ex);
            }
        }
    }
}

