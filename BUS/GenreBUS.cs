using System;
using System.Collections.Generic;
using System.Data;
using MusicLibraryManager.DAL;
using MusicLibraryManager.Entities;

namespace MusicLibraryManager.BUS
{
    public class GenreBUS
    {
        /// <summary>
        /// Lấy tất cả thể loại
        /// </summary>
        public static List<Genre> GetAllGenres()
        {
            try
            {
                return GenreDAO.GetAllGenres();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách thể loại: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Lấy thể loại theo ID
        /// </summary>
        public static Genre GetGenreByID(int genreID)
        {
            try
            {
                if (genreID <= 0)
                    throw new Exception("ID thể loại không hợp lệ");

                return GenreDAO.GetGenreByID(genreID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy thông tin thể loại: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Thêm thể loại mới
        /// </summary>
        public static int AddGenre(Genre genre)
        {
            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(genre.GenreName))
                    throw new Exception("Tên thể loại không được để trống");

                return GenreDAO.AddGenre(genre);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm thể loại: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Cập nhật thông tin thể loại
        /// </summary>
        public static bool UpdateGenre(Genre genre)
        {
            try
            {
                // Validation
                if (genre.GenreID <= 0)
                    throw new Exception("ID thể loại không hợp lệ");

                if (string.IsNullOrWhiteSpace(genre.GenreName))
                    throw new Exception("Tên thể loại không được để trống");

                return GenreDAO.UpdateGenre(genre);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật thể loại: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Xóa thể loại
        /// </summary>
        public static bool DeleteGenre(int genreID)
        {
            try
            {
                if (genreID <= 0)
                    throw new Exception("ID thể loại không hợp lệ");

                return GenreDAO.DeleteGenre(genreID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa thể loại: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Lấy thống kê theo thể loại
        /// </summary>
        public static DataTable GetStatsByGenre()
        {
            try
            {
                return GenreDAO.GetStatsByGenre();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy thống kê: {ex.Message}", ex);
            }
        }
    }
}

