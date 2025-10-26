using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MusicLibraryManager.Entities;

namespace MusicLibraryManager.DAL
{
    public class PlayHistoryDAO
    {
        /// <summary>
        /// Thêm lịch sử phát nhạc
        /// </summary>
        public static int AddPlayHistory(int userID, int songID, int? playDuration = null, string deviceName = null)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@UserID", userID),
                new SqlParameter("@SongID", songID),
                new SqlParameter("@PlayDuration", (object)playDuration ?? DBNull.Value),
                new SqlParameter("@DeviceName", (object)deviceName ?? DBNull.Value)
            };

            object result = DatabaseHelper.ExecuteScalar("sp_AddPlayHistory", parameters);
            return Convert.ToInt32(result);
        }

        /// <summary>
        /// Lấy lịch sử phát gần đây
        /// </summary>
        public static List<PlayHistory> GetRecentlyPlayed(int userID, int topN = 50)
        {
            List<PlayHistory> history = new List<PlayHistory>();
            SqlParameter[] parameters = {
                new SqlParameter("@UserID", userID),
                new SqlParameter("@TopN", topN)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery("sp_GetRecentlyPlayed", parameters);

            foreach (DataRow row in dt.Rows)
            {
                history.Add(MapDataRowToPlayHistory(row));
            }

            return history;
        }

        /// <summary>
        /// Lấy bài hát được nghe nhiều nhất
        /// </summary>
        public static DataTable GetMostPlayedSongs(int userID, int topN = 20)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@UserID", userID),
                new SqlParameter("@TopN", topN)
            };

            return DatabaseHelper.ExecuteQuery("sp_GetMostPlayedSongs", parameters);
        }

        /// <summary>
        /// Lấy lịch sử theo khoảng thời gian
        /// </summary>
        public static List<PlayHistory> GetPlayHistoryByDate(int userID, DateTime fromDate, DateTime toDate)
        {
            List<PlayHistory> history = new List<PlayHistory>();
            SqlParameter[] parameters = {
                new SqlParameter("@UserID", userID),
                new SqlParameter("@FromDate", fromDate),
                new SqlParameter("@ToDate", toDate)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery("sp_GetPlayHistoryByDate", parameters);

            foreach (DataRow row in dt.Rows)
            {
                history.Add(MapDataRowToPlayHistory(row));
            }

            return history;
        }

        /// <summary>
        /// Xóa lịch sử phát
        /// </summary>
        public static bool ClearPlayHistory(int userID, int? olderThanDays = null)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@UserID", userID),
                new SqlParameter("@OlderThanDays", (object)olderThanDays ?? DBNull.Value)
            };

            DatabaseHelper.ExecuteNonQuery("sp_ClearPlayHistory", parameters);
            return true;
        }

        /// <summary>
        /// Xóa một item lịch sử
        /// </summary>
        public static bool DeleteHistoryItem(int historyID, int userID)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@HistoryID", historyID),
                new SqlParameter("@UserID", userID)
            };

            int result = DatabaseHelper.ExecuteNonQuery("sp_DeleteHistoryItem", parameters);
            return result > 0;
        }

        /// <summary>
        /// Lấy thống kê nghe nhạc
        /// </summary>
        public static DataTable GetListeningStats(int userID)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@UserID", userID)
            };

            return DatabaseHelper.ExecuteQuery("sp_GetListeningStats", parameters);
        }

        /// <summary>
        /// Map DataRow sang PlayHistory object
        /// </summary>
        private static PlayHistory MapDataRowToPlayHistory(DataRow row)
        {
            return new PlayHistory
            {
                HistoryID = Convert.ToInt32(row["HistoryID"]),
                UserID = Convert.ToInt32(row["UserID"]),
                SongID = Convert.ToInt32(row["SongID"]),
                SongTitle = row["SongTitle"].ToString(),
                ArtistName = row["ArtistName"] != DBNull.Value ? row["ArtistName"].ToString() : "Unknown",
                GenreName = row["GenreName"] != DBNull.Value ? row["GenreName"].ToString() : "Unknown",
                PlayedDate = Convert.ToDateTime(row["PlayedDate"]),
                PlayDuration = row["PlayDuration"] != DBNull.Value ? (int?)Convert.ToInt32(row["PlayDuration"]) : null,
                DeviceName = row["DeviceName"] != DBNull.Value ? row["DeviceName"].ToString() : null,
                FilePath = row.Table.Columns.Contains("FilePath") && row["FilePath"] != DBNull.Value ? row["FilePath"].ToString() : null,
                Duration = row.Table.Columns.Contains("Duration") && row["Duration"] != DBNull.Value ? (int?)Convert.ToInt32(row["Duration"]) : null
            };
        }
    }
}

