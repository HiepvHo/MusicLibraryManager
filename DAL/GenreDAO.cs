using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MusicLibraryManager.Entities;

namespace MusicLibraryManager.DAL
{
    public class GenreDAO
    {
        /// <summary>
        /// Lấy tất cả thể loại (public + của user)
        /// </summary>
        public static List<Genre> GetAllGenres(int userID)
        {
            List<Genre> genres = new List<Genre>();
            SqlParameter[] parameters = {
                new SqlParameter("@UserID", userID)
            };
            DataTable dt = DatabaseHelper.ExecuteQuery("sp_GetAllGenres", parameters);

            foreach (DataRow row in dt.Rows)
            {
                genres.Add(MapDataRowToGenre(row));
            }

            return genres;
        }

        /// <summary>
        /// Lấy thể loại theo ID
        /// </summary>
        public static Genre GetGenreByID(int genreID)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@GenreID", genreID)
            };

            string query = "SELECT * FROM Genres WHERE GenreID = @GenreID";
            DataTable dt = DatabaseHelper.ExecuteQueryDirect(query, parameters);

            if (dt.Rows.Count > 0)
            {
                return MapDataRowToGenre(dt.Rows[0]);
            }

            return null;
        }

        /// <summary>
        /// Thêm thể loại mới
        /// </summary>
        public static int AddGenre(Genre genre, int userID)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@GenreName", genre.GenreName),
                new SqlParameter("@Description", (object)genre.Description ?? DBNull.Value),
                new SqlParameter("@UserID", userID)
            };

            object result = DatabaseHelper.ExecuteScalar("sp_InsertGenre", parameters);
            return Convert.ToInt32(result);
        }

        /// <summary>
        /// Cập nhật thông tin thể loại
        /// </summary>
        public static bool UpdateGenre(Genre genre, int userID)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@GenreID", genre.GenreID),
                new SqlParameter("@GenreName", genre.GenreName),
                new SqlParameter("@Description", (object)genre.Description ?? DBNull.Value),
                new SqlParameter("@UserID", userID)
            };

            int result = DatabaseHelper.ExecuteNonQuery("sp_UpdateGenre", parameters);
            return result > 0;
        }

        /// <summary>
        /// Xóa thể loại
        /// </summary>
        public static bool DeleteGenre(int genreID, int userID)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@GenreID", genreID),
                new SqlParameter("@UserID", userID)
            };

            int result = DatabaseHelper.ExecuteNonQuery("sp_DeleteGenre", parameters);
            return result > 0;
        }

        /// <summary>
        /// Thống kê theo thể loại
        /// </summary>
        public static DataTable GetStatsByGenre()
        {
            return DatabaseHelper.ExecuteQuery("sp_GetStatsByGenre");
        }

        /// <summary>
        /// Map DataRow sang Genre object
        /// </summary>
        private static Genre MapDataRowToGenre(DataRow row)
        {
            return new Genre
            {
                GenreID = Convert.ToInt32(row["GenreID"]),
                GenreName = row["GenreName"].ToString(),
                Description = row["Description"] != DBNull.Value ? row["Description"].ToString() : "",
                CreatedDate = row["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(row["CreatedDate"]) : DateTime.Now
            };
        }
    }
}

