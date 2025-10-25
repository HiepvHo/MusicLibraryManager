using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MusicLibraryManager.Entities;

namespace MusicLibraryManager.DAL
{
    public class PlaylistDAO
    {
        /// <summary>
        /// Lấy tất cả playlist
        /// </summary>
        public static List<Playlist> GetAllPlaylists()
        {
            List<Playlist> playlists = new List<Playlist>();
            DataTable dt = DatabaseHelper.ExecuteQuery("sp_GetAllPlaylists");

            foreach (DataRow row in dt.Rows)
            {
                playlists.Add(MapDataRowToPlaylist(row));
            }

            return playlists;
        }

        /// <summary>
        /// Lấy playlist theo ID
        /// </summary>
        public static Playlist GetPlaylistByID(int playlistID)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@PlaylistID", playlistID)
            };

            string query = "SELECT p.*, COUNT(ps.SongID) AS SongCount " +
                          "FROM Playlists p " +
                          "LEFT JOIN PlaylistSongs ps ON p.PlaylistID = ps.PlaylistID " +
                          "WHERE p.PlaylistID = @PlaylistID " +
                          "GROUP BY p.PlaylistID, p.PlaylistName, p.Description, p.CoverImagePath, " +
                          "p.IsPublic, p.CreatedDate, p.UpdatedDate";

            DataTable dt = DatabaseHelper.ExecuteQueryDirect(query, parameters);

            if (dt.Rows.Count > 0)
            {
                return MapDataRowToPlaylist(dt.Rows[0]);
            }

            return null;
        }

        /// <summary>
        /// Tạo playlist mới
        /// </summary>
        public static int CreatePlaylist(Playlist playlist)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@PlaylistName", playlist.PlaylistName),
                new SqlParameter("@Description", (object)playlist.Description ?? DBNull.Value),
                new SqlParameter("@CoverImagePath", (object)playlist.CoverImagePath ?? DBNull.Value)
            };

            object result = DatabaseHelper.ExecuteScalar("sp_CreatePlaylist", parameters);
            return Convert.ToInt32(result);
        }

        /// <summary>
        /// Cập nhật playlist
        /// </summary>
        public static bool UpdatePlaylist(Playlist playlist)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@PlaylistID", playlist.PlaylistID),
                new SqlParameter("@PlaylistName", playlist.PlaylistName),
                new SqlParameter("@Description", (object)playlist.Description ?? DBNull.Value),
                new SqlParameter("@CoverImagePath", (object)playlist.CoverImagePath ?? DBNull.Value),
                new SqlParameter("@IsPublic", playlist.IsPublic)
            };

            string query = "UPDATE Playlists SET PlaylistName = @PlaylistName, Description = @Description, " +
                          "CoverImagePath = @CoverImagePath, IsPublic = @IsPublic, UpdatedDate = GETDATE() " +
                          "WHERE PlaylistID = @PlaylistID";

            DataTable dt = DatabaseHelper.ExecuteQueryDirect(query, parameters);
            return true;
        }

        /// <summary>
        /// Xóa playlist
        /// </summary>
        public static bool DeletePlaylist(int playlistID)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@PlaylistID", playlistID)
            };

            string query = "DELETE FROM Playlists WHERE PlaylistID = @PlaylistID";
            DataTable dt = DatabaseHelper.ExecuteQueryDirect(query, parameters);
            return true;
        }

        /// <summary>
        /// Lấy các bài hát trong playlist
        /// </summary>
        public static List<Song> GetPlaylistSongs(int playlistID)
        {
            List<Song> songs = new List<Song>();
            SqlParameter[] parameters = {
                new SqlParameter("@PlaylistID", playlistID)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery("sp_GetPlaylistSongs", parameters);

            foreach (DataRow row in dt.Rows)
            {
                songs.Add(new Song
                {
                    SongID = Convert.ToInt32(row["SongID"]),
                    SongTitle = row["SongTitle"].ToString(),
                    ArtistName = row.Table.Columns.Contains("ArtistName") && row["ArtistName"] != DBNull.Value ? row["ArtistName"].ToString() : "",
                    AlbumName = row.Table.Columns.Contains("AlbumName") && row["AlbumName"] != DBNull.Value ? row["AlbumName"].ToString() : "",
                    GenreName = row.Table.Columns.Contains("GenreName") && row["GenreName"] != DBNull.Value ? row["GenreName"].ToString() : "",
                    Duration = row.Table.Columns.Contains("Duration") && row["Duration"] != DBNull.Value ? (int?)Convert.ToInt32(row["Duration"]) : null,
                    FilePath = row.Table.Columns.Contains("FilePath") && row["FilePath"] != DBNull.Value ? row["FilePath"].ToString() : ""
                });
            }

            return songs;
        }

        /// <summary>
        /// Thêm bài hát vào playlist
        /// </summary>
        public static bool AddSongToPlaylist(int playlistID, int songID)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@PlaylistID", playlistID),
                new SqlParameter("@SongID", songID)
            };

            try
            {
                int result = DatabaseHelper.ExecuteNonQuery("sp_AddSongToPlaylist", parameters);
                return result > 0;
            }
            catch
            {
                return false; // Có thể bị duplicate
            }
        }

        /// <summary>
        /// Xóa bài hát khỏi playlist
        /// </summary>
        public static bool RemoveSongFromPlaylist(int playlistID, int songID)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@PlaylistID", playlistID),
                new SqlParameter("@SongID", songID)
            };

            int result = DatabaseHelper.ExecuteNonQuery("sp_RemoveSongFromPlaylist", parameters);
            return result > 0;
        }

        /// <summary>
        /// Map DataRow sang Playlist object
        /// </summary>
        private static Playlist MapDataRowToPlaylist(DataRow row)
        {
            return new Playlist
            {
                PlaylistID = Convert.ToInt32(row["PlaylistID"]),
                PlaylistName = row["PlaylistName"].ToString(),
                Description = row.Table.Columns.Contains("Description") && row["Description"] != DBNull.Value ? row["Description"].ToString() : "",
                CoverImagePath = row.Table.Columns.Contains("CoverImagePath") && row["CoverImagePath"] != DBNull.Value ? row["CoverImagePath"].ToString() : "",
                IsPublic = row.Table.Columns.Contains("IsPublic") && row["IsPublic"] != DBNull.Value && Convert.ToBoolean(row["IsPublic"]),
                CreatedDate = row.Table.Columns.Contains("CreatedDate") && row["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(row["CreatedDate"]) : DateTime.Now,
                UpdatedDate = row.Table.Columns.Contains("UpdatedDate") && row["UpdatedDate"] != DBNull.Value ? Convert.ToDateTime(row["UpdatedDate"]) : DateTime.Now,
                SongCount = row.Table.Columns.Contains("SongCount") && row["SongCount"] != DBNull.Value ? Convert.ToInt32(row["SongCount"]) : 0
            };
        }
    }
}

