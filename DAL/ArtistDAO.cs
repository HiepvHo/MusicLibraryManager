using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MusicLibraryManager.Entities;

namespace MusicLibraryManager.DAL
{
    public class ArtistDAO
    {
        /// <summary>
        /// Lấy tất cả ca sĩ
        /// </summary>
        public static List<Artist> GetAllArtists()
        {
            List<Artist> artists = new List<Artist>();
            DataTable dt = DatabaseHelper.ExecuteQuery("sp_GetAllArtists");

            foreach (DataRow row in dt.Rows)
            {
                artists.Add(MapDataRowToArtist(row));
            }

            return artists;
        }

        /// <summary>
        /// Lấy ca sĩ theo ID
        /// </summary>
        public static Artist GetArtistByID(int artistID)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@ArtistID", artistID)
            };

            string query = "SELECT * FROM Artists WHERE ArtistID = @ArtistID";
            DataTable dt = DatabaseHelper.ExecuteQueryDirect(query, parameters);

            if (dt.Rows.Count > 0)
            {
                return MapDataRowToArtist(dt.Rows[0]);
            }

            return null;
        }

        /// <summary>
        /// Thêm ca sĩ mới
        /// </summary>
        public static int AddArtist(Artist artist)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@ArtistName", artist.ArtistName),
                new SqlParameter("@Biography", (object)artist.Biography ?? DBNull.Value),
                new SqlParameter("@Country", (object)artist.Country ?? DBNull.Value),
                new SqlParameter("@ImagePath", (object)artist.ImagePath ?? DBNull.Value)
            };

            object result = DatabaseHelper.ExecuteScalar("sp_AddArtist", parameters);
            return Convert.ToInt32(result);
        }

        /// <summary>
        /// Cập nhật thông tin ca sĩ
        /// </summary>
        public static bool UpdateArtist(Artist artist)
        {
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@ArtistID", artist.ArtistID),
                    new SqlParameter("@ArtistName", artist.ArtistName),
                    new SqlParameter("@Biography", (object)artist.Biography ?? DBNull.Value),
                    new SqlParameter("@Country", (object)artist.Country ?? DBNull.Value),
                    new SqlParameter("@ImagePath", (object)artist.ImagePath ?? DBNull.Value)
                };

                int result = DatabaseHelper.ExecuteNonQuery("sp_UpdateArtist", parameters);
                
                // Debug log
                System.Diagnostics.Debug.WriteLine($"UpdateArtist: ArtistID={artist.ArtistID}, Result={result}");
                
                return result > 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"UpdateArtist Error: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Xóa ca sĩ
        /// </summary>
        public static bool DeleteArtist(int artistID)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@ArtistID", artistID)
            };

            string query = "DELETE FROM Artists WHERE ArtistID = @ArtistID";
            DataTable dt = DatabaseHelper.ExecuteQueryDirect(query, parameters);
            return true;
        }

        /// <summary>
        /// Tìm kiếm ca sĩ theo tên
        /// </summary>
        public static List<Artist> SearchArtists(string searchTerm)
        {
            List<Artist> artists = new List<Artist>();
            SqlParameter[] parameters = {
                new SqlParameter("@SearchTerm", searchTerm)
            };

            string query = "SELECT * FROM Artists WHERE ArtistName LIKE N'%' + @SearchTerm + '%' ORDER BY ArtistName";
            DataTable dt = DatabaseHelper.ExecuteQueryDirect(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                artists.Add(MapDataRowToArtist(row));
            }

            return artists;
        }

        /// <summary>
        /// Map DataRow sang Artist object
        /// </summary>
        private static Artist MapDataRowToArtist(DataRow row)
        {
            return new Artist
            {
                ArtistID = Convert.ToInt32(row["ArtistID"]),
                ArtistName = row["ArtistName"].ToString(),
                Biography = row["Biography"] != DBNull.Value ? row["Biography"].ToString() : "",
                Country = row["Country"] != DBNull.Value ? row["Country"].ToString() : "",
                ImagePath = row["ImagePath"] != DBNull.Value ? row["ImagePath"].ToString() : "",
                CreatedDate = row["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(row["CreatedDate"]) : DateTime.Now,
                UpdatedDate = row["UpdatedDate"] != DBNull.Value ? Convert.ToDateTime(row["UpdatedDate"]) : DateTime.Now
            };
        }
    }
}

