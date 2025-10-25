using System;
using System.Data;
using MusicLibraryManager.DAL;

namespace MusicLibraryManager.BUS
{
    public class SettingBUS
    {
        /// <summary>
        /// Lấy giá trị setting
        /// </summary>
        public static string GetSetting(string key, string defaultValue = "")
        {
            try
            {
                string value = SettingDAO.GetSetting(key);
                return string.IsNullOrEmpty(value) ? defaultValue : value;
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// Cập nhật setting
        /// </summary>
        public static bool UpdateSetting(string key, string value)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(key))
                    throw new Exception("Key không được để trống");

                return SettingDAO.UpdateSetting(key, value);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật setting: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Lấy tất cả settings
        /// </summary>
        public static DataTable GetAllSettings()
        {
            try
            {
                return SettingDAO.GetAllSettings();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách settings: {ex.Message}", ex);
            }
        }

        // Helper methods cho các setting thường dùng

        public static string GetTheme()
        {
            return GetSetting("Theme", "Light");
        }

        public static bool SetTheme(string theme)
        {
            return UpdateSetting("Theme", theme);
        }

        public static int GetVolume()
        {
            string value = GetSetting("Volume", "50");
            int.TryParse(value, out int volume);
            return volume;
        }

        public static bool SetVolume(int volume)
        {
            return UpdateSetting("Volume", volume.ToString());
        }

        public static string GetRepeatMode()
        {
            return GetSetting("RepeatMode", "None");
        }

        public static bool SetRepeatMode(string mode)
        {
            return UpdateSetting("RepeatMode", mode);
        }

        public static bool GetShuffleMode()
        {
            string value = GetSetting("ShuffleMode", "False");
            bool.TryParse(value, out bool shuffle);
            return shuffle;
        }

        public static bool SetShuffleMode(bool shuffle)
        {
            return UpdateSetting("ShuffleMode", shuffle.ToString());
        }

        public static string GetDefaultMusicFolder()
        {
            return GetSetting("DefaultMusicFolder", Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
        }

        public static bool SetDefaultMusicFolder(string folder)
        {
            return UpdateSetting("DefaultMusicFolder", folder);
        }
    }
}

