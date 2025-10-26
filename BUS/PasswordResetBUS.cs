using System;
using MusicLibraryManager.DAL;
using MusicLibraryManager.Entities;
using MusicLibraryManager.Helpers;

namespace MusicLibraryManager.BUS
{
    public class PasswordResetBUS
    {
        /// <summary>
        /// Yêu cầu reset password - Gửi mã qua email
        /// </summary>
        public static bool RequestPasswordReset(string email)
        {
            try
            {
                // 1. Kiểm tra email có hợp lệ không
                if (string.IsNullOrWhiteSpace(email))
                    throw new Exception("Vui lòng nhập email!");

                if (!IsValidEmail(email))
                    throw new Exception("Email không hợp lệ!");

                // 2. Tìm user theo email
                User user = UserDAO.GetUserByEmail(email.Trim());
                if (user == null)
                    throw new Exception("Email này không tồn tại trong hệ thống!");

                // 3. Tạo token reset (GUID)
                string token = Guid.NewGuid().ToString();

                // 4. Lưu token vào database (thời hạn 30 phút)
                int tokenID = PasswordResetTokenDAO.CreateResetToken(user.UserID, token, 30);
                
                if (tokenID <= 0)
                    throw new Exception("Không thể tạo mã khôi phục!");

                // 5. Gửi email chứa token
                bool emailSent = EmailHelper.SendPasswordResetEmail(email, user.Username, token);
                
                if (!emailSent)
                    throw new Exception("Không thể gửi email!");

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi yêu cầu reset password: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Reset password bằng token
        /// </summary>
        public static bool ResetPasswordWithToken(string token, string newPassword)
        {
            try
            {
                // 1. Validate input
                if (string.IsNullOrWhiteSpace(token))
                    throw new Exception("Vui lòng nhập mã khôi phục!");

                if (string.IsNullOrWhiteSpace(newPassword))
                    throw new Exception("Vui lòng nhập mật khẩu mới!");

                if (newPassword.Length < 6)
                    throw new Exception("Mật khẩu phải có ít nhất 6 ký tự!");

                // 2. Verify token (có thể là mã ngắn hoặc đầy đủ)
                PasswordResetToken resetToken = PasswordResetTokenDAO.VerifyResetToken(token);
                
                if (resetToken == null)
                    throw new Exception("Mã khôi phục không hợp lệ!");

                // 3. Kiểm tra token status
                if (resetToken.IsUsed)
                    throw new Exception("Mã khôi phục đã được sử dụng!");

                if (resetToken.ExpiresAt < DateTime.Now)
                    throw new Exception("Mã khôi phục đã hết hạn!");

                // 4. Hash mật khẩu mới
                string hashedPassword = SecurityHelper.HashPassword(newPassword);

                // 5. Update mật khẩu trong database
                bool updated = UserDAO.UpdatePasswordByUserID(resetToken.UserID, hashedPassword);
                
                if (!updated)
                    throw new Exception("Không thể cập nhật mật khẩu!");

                // 6. Đánh dấu token đã sử dụng (dùng token đầy đủ từ DB)
                PasswordResetTokenDAO.MarkTokenAsUsed(resetToken.Token);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi đặt lại mật khẩu: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Verify token (chỉ kiểm tra, không reset password)
        /// </summary>
        public static PasswordResetToken VerifyToken(string token)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(token))
                    return null;

                string normalizedToken = NormalizeToken(token);
                return PasswordResetTokenDAO.VerifyResetToken(normalizedToken);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Cleanup expired tokens (chạy định kỳ)
        /// </summary>
        public static int CleanupExpiredTokens()
        {
            try
            {
                return PasswordResetTokenDAO.CleanupExpiredTokens();
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Chuẩn hóa token (remove spaces, dashes, uppercase)
        /// </summary>
        private static string NormalizeToken(string token)
        {
            // Remove spaces và dấu gạch ngang
            string normalized = token.Replace(" ", "").Replace("-", "").Trim();
            
            // Nếu user nhập token ngắn (12 ký tự), tìm GUID tương ứng
            // Nếu là GUID đầy đủ, return as is
            if (normalized.Length == 32 || normalized.Length == 36) // GUID without/with dashes
            {
                // Try parse as GUID
                if (Guid.TryParse(normalized, out Guid guid))
                {
                    return guid.ToString();
                }
            }
            
            return normalized;
        }

        /// <summary>
        /// Validate email format
        /// </summary>
        private static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}

