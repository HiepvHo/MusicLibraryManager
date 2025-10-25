using System;

namespace MusicLibraryManager.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastLoginDate { get; set; }

        public User()
        {
            IsActive = true;
            CreatedDate = DateTime.Now;
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}

