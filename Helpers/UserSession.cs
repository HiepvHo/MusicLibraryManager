using System;
using MusicLibraryManager.Entities;

namespace MusicLibraryManager.Helpers
{
    /// <summary>
    /// Quản lý thông tin user đang đăng nhập
    /// </summary>
    public static class UserSession
    {
        /// <summary>
        /// User hiện tại đang đăng nhập
        /// </summary>
        public static User CurrentUser { get; set; }

        /// <summary>
        /// UserID của user đang đăng nhập
        /// </summary>
        public static int CurrentUserID
        {
            get
            {
                if (CurrentUser == null)
                {
                    throw new InvalidOperationException("Chưa có user nào đăng nhập! Vui lòng đăng nhập trước.");
                }
                return CurrentUser.UserID;
            }
        }

        /// <summary>
        /// Kiểm tra có user đang đăng nhập không
        /// </summary>
        public static bool IsLoggedIn
        {
            get { return CurrentUser != null; }
        }

        /// <summary>
        /// Đăng xuất
        /// </summary>
        public static void Logout()
        {
            CurrentUser = null;
        }

        /// <summary>
        /// Đăng nhập
        /// </summary>
        public static void Login(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user), "User không được null!");
            }
            CurrentUser = user;
        }
    }
}

