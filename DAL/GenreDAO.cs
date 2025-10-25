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
        /// Lấy tất cả thể loại
        /// </summary>
        public static List<Genre> GetAllGenres()
        {
            List<Genre> genres = new List<Genre>();
            DataTable dt = DatabaseHelper.ExecuteQuery("sp_GetAllGenres");

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
        public static int AddGenre(Genre genre)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@GenreName", genre.GenreName),
                new SqlParameter("@Description", (object)genre.Description ?? DBNull.Value)
            };

            object result = DatabaseHelper.ExecuteScalar("sp_AddGenre", parameters);
            return Convert.ToInt32(result);
        }

        /// <summary>
        /// Cập nhật thông tin thể loại
        /// </summary>
        public static bool UpdateGenre(Genre genre)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@GenreID", genre.GenreID),
                new SqlParameter("@GenreName", genre.GenreName),
                new SqlParameter("@Description", (object)genre.Description ?? DBNull.Value)
            };

            string query = "UPDATE Genres SET GenreName = @GenreName, Description = @Description WHERE GenreID = @GenreID";
            DataTable dt = DatabaseHelper.ExecuteQueryDirect(query, parameters);
            return true;
        }

        /// <summary>
        /// Xóa thể loại
        /// </summary>
        public static bool DeleteGenre(int genreID)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@GenreID", genreID)
            };

            string query = "DELETE FROM Genres WHERE GenreID = @GenreID";
            DataTable dt = DatabaseHelper.ExecuteQueryDirect(query, parameters);
            return true;
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

