using System;

namespace MusicLibraryManager.Entities
{
    /// <summary>
    /// Entity đại diện cho token reset password
    /// </summary>
    public class PasswordResetToken
    {
        public int TokenID { get; set; }
        public int UserID { get; set; }
        public string Token { get; set; }
        public DateTime ExpiresAt { get; set; }
        public bool IsUsed { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UsedDate { get; set; }
        
        // Navigation properties
        public string Username { get; set; }
        public string Email { get; set; }
        
        // Computed properties
        public string TokenStatus
        {
            get
            {
                if (IsUsed)
                    return "USED";
                if (ExpiresAt < DateTime.Now)
                    return "EXPIRED";
                return "VALID";
            }
        }
        
        public bool IsValid => TokenStatus == "VALID";
        
        public TimeSpan TimeRemaining => IsValid ? ExpiresAt - DateTime.Now : TimeSpan.Zero;
        
        public string TimeRemainingFormatted
        {
            get
            {
                if (!IsValid)
                    return "Đã hết hạn";
                    
                var remaining = TimeRemaining;
                if (remaining.TotalMinutes < 1)
                    return "Còn dưới 1 phút";
                else if (remaining.TotalHours < 1)
                    return $"Còn {(int)remaining.TotalMinutes} phút";
                else
                    return $"Còn {remaining.Hours} giờ {remaining.Minutes} phút";
            }
        }
    }
}

