using System;
using MusicLibraryManager.DAL;
using MusicLibraryManager.Entities;
using MusicLibraryManager.Helpers;

namespace MusicLibraryManager.BUS
{
    public class UserBUS
    {
        /// <summary>
        /// Đăng nhập
        /// </summary>
        public static User Login(string username, string password)
        {
            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(username))
                    throw new Exception("Tên đăng nhập không được để trống");

                if (string.IsNullOrWhiteSpace(password))
                    throw new Exception("Mật khẩu không được để trống");

                // Mã hóa password
                string passwordHash = SecurityHelper.HashPassword(password);

                // Gọi DAO để đăng nhập
                User user = UserDAO.Login(username, passwordHash);

                if (user == null)
                    throw new Exception("Tên đăng nhập hoặc mật khẩu không đúng!");

                return user;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi đăng nhập: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Đăng ký user mới
        /// </summary>
        public static int RegisterUser(string username, string password, string fullName, string email = "")
        {
            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(username))
                    throw new Exception("Tên đăng nhập không được để trống");

                if (string.IsNullOrWhiteSpace(password))
                    throw new Exception("Mật khẩu không được để trống");

                if (password.Length < 6)
                    throw new Exception("Mật khẩu phải có ít nhất 6 ký tự");

                if (string.IsNullOrWhiteSpace(fullName))
                    throw new Exception("Họ tên không được để trống");

                // Mã hóa password
                string passwordHash = SecurityHelper.HashPassword(password);

                User newUser = new User
                {
                    Username = username.Trim(),
                    Password = passwordHash,
                    FullName = fullName.Trim(),
                    Email = email.Trim()
                };

                int result = UserDAO.RegisterUser(newUser);

                if (result == -1)
                    throw new Exception("Tên đăng nhập đã tồn tại!");

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi đăng ký: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Đổi mật khẩu
        /// </summary>
        public static bool ChangePassword(int userID, string oldPassword, string newPassword)
        {
            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(oldPassword))
                    throw new Exception("Mật khẩu cũ không được để trống");

                if (string.IsNullOrWhiteSpace(newPassword))
                    throw new Exception("Mật khẩu mới không được để trống");

                if (newPassword.Length < 6)
                    throw new Exception("Mật khẩu mới phải có ít nhất 6 ký tự");

                // Mã hóa passwords
                string oldPasswordHash = SecurityHelper.HashPassword(oldPassword);
                string newPasswordHash = SecurityHelper.HashPassword(newPassword);

                bool success = UserDAO.ChangePassword(userID, oldPasswordHash, newPasswordHash);

                if (!success)
                    throw new Exception("Mật khẩu cũ không đúng!");

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi đổi mật khẩu: {ex.Message}", ex);
            }
        }
    }
}

