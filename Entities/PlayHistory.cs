using System;

namespace MusicLibraryManager.Entities
{
    /// <summary>
    /// Entity đại diện cho lịch sử phát nhạc
    /// </summary>
    public class PlayHistory
    {
        public int HistoryID { get; set; }
        public int UserID { get; set; }
        public int SongID { get; set; }
        public DateTime PlayedDate { get; set; }
        public int? PlayDuration { get; set; } // Số giây đã nghe
        public string DeviceName { get; set; }
        
        // Navigation properties (từ JOIN)
        public string SongTitle { get; set; }
        public string ArtistName { get; set; }
        public string GenreName { get; set; }
        public string FilePath { get; set; }
        public int? Duration { get; set; } // Tổng thời lượng bài hát
        
        // Computed properties
        public string PlayedDateFormatted
        {
            get
            {
                TimeSpan timeSince = DateTime.Now - PlayedDate;
                
                if (timeSince.TotalMinutes < 1)
                    return "Vừa xong";
                else if (timeSince.TotalMinutes < 60)
                    return $"{(int)timeSince.TotalMinutes} phút trước";
                else if (timeSince.TotalHours < 24)
                    return $"{(int)timeSince.TotalHours} giờ trước";
                else if (timeSince.TotalDays < 7)
                    return $"{(int)timeSince.TotalDays} ngày trước";
                else
                    return PlayedDate.ToString("dd/MM/yyyy HH:mm");
            }
        }
        
        public string PlayDurationFormatted
        {
            get
            {
                if (!PlayDuration.HasValue || PlayDuration.Value <= 0)
                    return "N/A";
                    
                int minutes = PlayDuration.Value / 60;
                int seconds = PlayDuration.Value % 60;
                return $"{minutes:D2}:{seconds:D2}";
            }
        }
        
        public double CompletionPercentage
        {
            get
            {
                if (!PlayDuration.HasValue || !Duration.HasValue || Duration.Value == 0)
                    return 0;
                    
                return Math.Min(100, (PlayDuration.Value * 100.0 / Duration.Value));
            }
        }
    }
}

