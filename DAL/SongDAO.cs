using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MusicLibraryManager.Entities;

namespace MusicLibraryManager.DAL
{
    public class SongDAO
    {
        /// <summary>
        /// Lấy tất cả bài hát
        /// </summary>
        public static List<Song> GetAllSongs()
        {
            List<Song> songs = new List<Song>();
            DataTable dt = DatabaseHelper.ExecuteQuery("sp_GetAllSongs");

            foreach (DataRow row in dt.Rows)
            {
                songs.Add(MapDataRowToSong(row));
            }

            return songs;
        }

        /// <summary>
        /// Lấy bài hát theo ID
        /// </summary>
        public static Song GetSongByID(int songID)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@SongID", songID)
            };

            string query = "SELECT s.*, a.ArtistName, al.AlbumName, g.GenreName " +
                          "FROM Songs s " +
                          "LEFT JOIN Artists a ON s.ArtistID = a.ArtistID " +
                          "LEFT JOIN Albums al ON s.AlbumID = al.AlbumID " +
                          "LEFT JOIN Genres g ON s.GenreID = g.GenreID " +
                          "WHERE s.SongID = @SongID";

            DataTable dt = DatabaseHelper.ExecuteQueryDirect(query, parameters);

            if (dt.Rows.Count > 0)
            {
                return MapDataRowToSong(dt.Rows[0]);
            }

            return null;
        }

        /// <summary>
        /// Thêm bài hát mới
        /// </summary>
        public static int AddSong(Song song)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@SongTitle", song.SongTitle),
                new SqlParameter("@ArtistID", (object)song.ArtistID ?? DBNull.Value),
                new SqlParameter("@AlbumID", (object)song.AlbumID ?? DBNull.Value),
                new SqlParameter("@GenreID", (object)song.GenreID ?? DBNull.Value),
                new SqlParameter("@Duration", (object)song.Duration ?? DBNull.Value),
                new SqlParameter("@FilePath", song.FilePath),
                new SqlParameter("@ReleaseYear", (object)song.ReleaseYear ?? DBNull.Value),
                new SqlParameter("@Lyrics", (object)song.Lyrics ?? DBNull.Value),
                new SqlParameter("@FileSize", (object)song.FileSize ?? DBNull.Value),
                new SqlParameter("@BitRate", (object)song.BitRate ?? DBNull.Value)
            };

            object result = DatabaseHelper.ExecuteScalar("sp_AddSong", parameters);
            return Convert.ToInt32(result);
        }

        /// <summary>
        /// Cập nhật thông tin bài hát
        /// </summary>
        public static bool UpdateSong(Song song)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@SongID", song.SongID),
                new SqlParameter("@SongTitle", song.SongTitle),
                new SqlParameter("@ArtistID", (object)song.ArtistID ?? DBNull.Value),
                new SqlParameter("@AlbumID", (object)song.AlbumID ?? DBNull.Value),
                new SqlParameter("@GenreID", (object)song.GenreID ?? DBNull.Value),
                new SqlParameter("@Duration", (object)song.Duration ?? DBNull.Value),
                new SqlParameter("@ReleaseYear", (object)song.ReleaseYear ?? DBNull.Value),
                new SqlParameter("@Lyrics", (object)song.Lyrics ?? DBNull.Value),
                new SqlParameter("@Rating", (object)song.Rating ?? DBNull.Value)
            };

            int result = DatabaseHelper.ExecuteNonQuery("sp_UpdateSong", parameters);
            return result > 0;
        }

        /// <summary>
        /// Xóa bài hát
        /// </summary>
        public static bool DeleteSong(int songID)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@SongID", songID)
            };

            int result = DatabaseHelper.ExecuteNonQuery("sp_DeleteSong", parameters);
            return result > 0;
        }

        /// <summary>
        /// Tìm kiếm bài hát
        /// </summary>
        public static List<Song> SearchSongs(string searchTerm)
        {
            List<Song> songs = new List<Song>();
            SqlParameter[] parameters = {
                new SqlParameter("@SearchTerm", searchTerm)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery("sp_SearchSongs", parameters);

            foreach (DataRow row in dt.Rows)
            {
                songs.Add(MapDataRowToSong(row));
            }

            return songs;
        }

        /// <summary>
        /// Cập nhật số lần phát
        /// </summary>
        public static bool UpdatePlayCount(int songID)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@SongID", songID)
            };

            int result = DatabaseHelper.ExecuteNonQuery("sp_UpdatePlayCount", parameters);
            return result > 0;
        }

        /// <summary>
        /// Toggle yêu thích
        /// </summary>
        public static bool ToggleFavorite(int songID)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@SongID", songID)
            };

            int result = DatabaseHelper.ExecuteNonQuery("sp_ToggleFavorite", parameters);
            return result > 0;
        }

        /// <summary>
        /// Lấy danh sách bài hát yêu thích
        /// </summary>
        public static List<Song> GetFavoriteSongs()
        {
            List<Song> songs = new List<Song>();
            DataTable dt = DatabaseHelper.ExecuteQuery("sp_GetFavoriteSongs");

            foreach (DataRow row in dt.Rows)
            {
                songs.Add(MapDataRowToSong(row));
            }

            return songs;
        }

        /// <summary>
        /// Lấy top bài hát được nghe nhiều nhất
        /// </summary>
        public static List<Song> GetTopPlayedSongs(int topCount = 10)
        {
            List<Song> songs = new List<Song>();
            SqlParameter[] parameters = {
                new SqlParameter("@TopCount", topCount)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery("sp_GetTopPlayedSongs", parameters);

            foreach (DataRow row in dt.Rows)
            {
                songs.Add(MapDataRowToSong(row));
            }

            return songs;
        }

        /// <summary>
        /// Map DataRow sang Song object
        /// </summary>
        private static Song MapDataRowToSong(DataRow row)
        {
            return new Song
            {
                SongID = Convert.ToInt32(row["SongID"]),
                SongTitle = row["SongTitle"].ToString(),
                ArtistID = row.Table.Columns.Contains("ArtistID") && row["ArtistID"] != DBNull.Value ? (int?)Convert.ToInt32(row["ArtistID"]) : null,
                ArtistName = row.Table.Columns.Contains("ArtistName") && row["ArtistName"] != DBNull.Value ? row["ArtistName"].ToString() : "",
                AlbumID = row.Table.Columns.Contains("AlbumID") && row["AlbumID"] != DBNull.Value ? (int?)Convert.ToInt32(row["AlbumID"]) : null,
                AlbumName = row.Table.Columns.Contains("AlbumName") && row["AlbumName"] != DBNull.Value ? row["AlbumName"].ToString() : "",
                GenreID = row.Table.Columns.Contains("GenreID") && row["GenreID"] != DBNull.Value ? (int?)Convert.ToInt32(row["GenreID"]) : null,
                GenreName = row.Table.Columns.Contains("GenreName") && row["GenreName"] != DBNull.Value ? row["GenreName"].ToString() : "",
                Duration = row.Table.Columns.Contains("Duration") && row["Duration"] != DBNull.Value ? (int?)Convert.ToInt32(row["Duration"]) : null,
                FilePath = row.Table.Columns.Contains("FilePath") && row["FilePath"] != DBNull.Value ? row["FilePath"].ToString() : "",
                ReleaseYear = row.Table.Columns.Contains("ReleaseYear") && row["ReleaseYear"] != DBNull.Value ? (int?)Convert.ToInt32(row["ReleaseYear"]) : null,
                PlayCount = row.Table.Columns.Contains("PlayCount") && row["PlayCount"] != DBNull.Value ? Convert.ToInt32(row["PlayCount"]) : 0,
                IsFavorite = row.Table.Columns.Contains("IsFavorite") && row["IsFavorite"] != DBNull.Value && Convert.ToBoolean(row["IsFavorite"]),
                Rating = row.Table.Columns.Contains("Rating") && row["Rating"] != DBNull.Value ? (int?)Convert.ToInt32(row["Rating"]) : null,
                LastPlayedDate = row.Table.Columns.Contains("LastPlayedDate") && row["LastPlayedDate"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row["LastPlayedDate"]) : null,
                CreatedDate = row.Table.Columns.Contains("CreatedDate") && row["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(row["CreatedDate"]) : DateTime.Now,
                Lyrics = row.Table.Columns.Contains("Lyrics") && row["Lyrics"] != DBNull.Value ? row["Lyrics"].ToString() : "",
                FileSize = row.Table.Columns.Contains("FileSize") && row["FileSize"] != DBNull.Value ? (long?)Convert.ToInt64(row["FileSize"]) : null,
                BitRate = row.Table.Columns.Contains("BitRate") && row["BitRate"] != DBNull.Value ? (int?)Convert.ToInt32(row["BitRate"]) : null
            };
        }
    }
}

