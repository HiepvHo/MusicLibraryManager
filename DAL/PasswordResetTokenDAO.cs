using System;
using System.Data;
using System.Data.SqlClient;
using MusicLibraryManager.Entities;

namespace MusicLibraryManager.DAL
{
    public class PasswordResetTokenDAO
    {
        /// <summary>
        /// Tạo token reset password mới
        /// </summary>
        public static int CreateResetToken(int userID, string token, int expiryMinutes = 30)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@UserID", userID),
                new SqlParameter("@Token", token),
                new SqlParameter("@ExpiryMinutes", expiryMinutes)
            };

            object result = DatabaseHelper.ExecuteScalar("sp_CreateResetToken", parameters);
            return Convert.ToInt32(result);
        }

        /// <summary>
        /// Kiểm tra và lấy thông tin token
        /// </summary>
        public static PasswordResetToken VerifyResetToken(string token)
        {
            // Nếu token ngắn (12 ký tự), dùng SP tìm bằng short code
            string cleanToken = token.Replace("-", "").Replace(" ", "").Trim();
            
            SqlParameter[] parameters;
            string spName;
            
            if (cleanToken.Length <= 20)
            {
                // Token ngắn - tìm bằng LIKE
                spName = "sp_VerifyResetTokenByShortCode";
                parameters = new SqlParameter[] {
                    new SqlParameter("@ShortCode", token)
                };
            }
            else
            {
                // Token đầy đủ - tìm chính xác
                spName = "sp_VerifyResetToken";
                parameters = new SqlParameter[] {
                    new SqlParameter("@Token", token)
                };
            }

            DataTable dt = DatabaseHelper.ExecuteQuery(spName, parameters);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];
            return new PasswordResetToken
            {
                TokenID = Convert.ToInt32(row["TokenID"]),
                UserID = Convert.ToInt32(row["UserID"]),
                Username = row["Username"].ToString(),
                Email = row["Email"].ToString(),
                ExpiresAt = Convert.ToDateTime(row["ExpiresAt"]),
                IsUsed = Convert.ToBoolean(row["IsUsed"]),
                Token = row["Token"].ToString() // Lấy token đầy đủ từ DB
            };
        }

        /// <summary>
        /// Đánh dấu token đã sử dụng
        /// </summary>
        public static bool MarkTokenAsUsed(string token)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Token", token)
            };

            int result = DatabaseHelper.ExecuteNonQuery("sp_MarkTokenAsUsed", parameters);
            return result > 0;
        }

        /// <summary>
        /// Xóa các token đã hết hạn (cleanup)
        /// </summary>
        public static int CleanupExpiredTokens()
        {
            object result = DatabaseHelper.ExecuteScalar("sp_CleanupExpiredTokens", null);
            return result != null ? Convert.ToInt32(result) : 0;
        }
    }
}

