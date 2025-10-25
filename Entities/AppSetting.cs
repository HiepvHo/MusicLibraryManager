using System;

namespace MusicLibraryManager.Entities
{
    public class AppSetting
    {
        public int SettingID { get; set; }
        public string SettingKey { get; set; }
        public string SettingValue { get; set; }
        public string Description { get; set; }
        public DateTime UpdatedDate { get; set; }

        public AppSetting()
        {
            UpdatedDate = DateTime.Now;
        }
    }
}

