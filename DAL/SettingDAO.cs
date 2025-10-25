using System;
using System.Data;
using System.Data.SqlClient;
using MusicLibraryManager.Entities;

namespace MusicLibraryManager.DAL
{
    public class SettingDAO
    {
        /// <summary>
        /// Lấy giá trị setting
        /// </summary>
        public static string GetSetting(string key)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@SettingKey", key)
            };

            object result = DatabaseHelper.ExecuteScalar("sp_GetSetting", parameters);
            return result != null ? result.ToString() : "";
        }

        /// <summary>
        /// Cập nhật setting
        /// </summary>
        public static bool UpdateSetting(string key, string value)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@SettingKey", key),
                new SqlParameter("@SettingValue", value)
            };

            int result = DatabaseHelper.ExecuteNonQuery("sp_UpdateSetting", parameters);
            return result > 0;
        }

        /// <summary>
        /// Lấy tất cả settings
        /// </summary>
        public static DataTable GetAllSettings()
        {
            string query = "SELECT * FROM Settings ORDER BY SettingKey";
            return DatabaseHelper.ExecuteQueryDirect(query);
        }
    }
}

