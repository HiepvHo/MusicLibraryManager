using System;
using System.Collections.Generic;
using System.Data;
using MusicLibraryManager.DAL;
using MusicLibraryManager.Entities;
using MusicLibraryManager.Helpers;

namespace MusicLibraryManager.BUS
{
    public class PlayHistoryBUS
    {
        /// <summary>
        /// Thêm lịch sử phát nhạc
        /// </summary>
        public static int AddPlayHistory(int songID, int? playDuration = null)
        {
            try
            {
                if (songID <= 0)
                    throw new Exception("ID bài hát không hợp lệ");

                string deviceName = Environment.MachineName;
                return PlayHistoryDAO.AddPlayHistory(UserSession.CurrentUserID, songID, playDuration, deviceName);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm lịch sử: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Lấy lịch sử phát gần đây
        /// </summary>
        public static List<PlayHistory> GetRecentlyPlayed(int topN = 50)
        {
            try
            {
                return PlayHistoryDAO.GetRecentlyPlayed(UserSession.CurrentUserID, topN);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy lịch sử: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Lấy bài hát được nghe nhiều nhất
        /// </summary>
        public static DataTable GetMostPlayedSongs(int topN = 20)
        {
            try
            {
                return PlayHistoryDAO.GetMostPlayedSongs(UserSession.CurrentUserID, topN);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy bài hát phổ biến: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Lấy lịch sử theo khoảng thời gian
        /// </summary>
        public static List<PlayHistory> GetPlayHistoryByDate(DateTime fromDate, DateTime toDate)
        {
            try
            {
                if (fromDate > toDate)
                    throw new Exception("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");

                return PlayHistoryDAO.GetPlayHistoryByDate(UserSession.CurrentUserID, fromDate, toDate);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy lịch sử theo ngày: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Xóa toàn bộ lịch sử
        /// </summary>
        public static bool ClearAllHistory()
        {
            try
            {
                return PlayHistoryDAO.ClearPlayHistory(UserSession.CurrentUserID, null);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa lịch sử: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Xóa lịch sử cũ hơn X ngày
        /// </summary>
        public static bool ClearOldHistory(int olderThanDays)
        {
            try
            {
                if (olderThanDays <= 0)
                    throw new Exception("Số ngày phải lớn hơn 0");

                return PlayHistoryDAO.ClearPlayHistory(UserSession.CurrentUserID, olderThanDays);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa lịch sử cũ: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Xóa một item lịch sử
        /// </summary>
        public static bool DeleteHistoryItem(int historyID)
        {
            try
            {
                if (historyID <= 0)
                    throw new Exception("ID lịch sử không hợp lệ");

                return PlayHistoryDAO.DeleteHistoryItem(historyID, UserSession.CurrentUserID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa item: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Lấy thống kê nghe nhạc
        /// </summary>
        public static DataTable GetListeningStats()
        {
            try
            {
                return PlayHistoryDAO.GetListeningStats(UserSession.CurrentUserID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy thống kê: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Lấy tổng số lần phát
        /// </summary>
        public static int GetTotalPlayCount()
        {
            try
            {
                DataTable dt = GetListeningStats();
                if (dt.Rows.Count > 0)
                {
                    return Convert.ToInt32(dt.Rows[0]["TotalPlays"]);
                }
                return 0;
            }
            catch
            {
                return 0;
            }
        }
    }
}

