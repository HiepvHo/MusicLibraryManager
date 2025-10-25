using System;
using System.Data;
using System.Data.SqlClient;
using MusicLibraryManager.Entities;

namespace MusicLibraryManager.DAL
{
    public class UserDAO
    {
        /// <summary>
        /// Đăng nhập
        /// </summary>
        public static User Login(string username, string passwordHash)
        {
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@Username", username),
                    new SqlParameter("@Password", passwordHash)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery("sp_Login", parameters);

                if (dt.Rows.Count > 0 && dt.Rows[0]["UserID"] != DBNull.Value)
                {
                    return MapDataRowToUser(dt.Rows[0]);
                }

                return null; // Đăng nhập thất bại
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi đăng nhập: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Đăng ký user mới
        /// </summary>
        public static int RegisterUser(User user)
        {
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@Username", user.Username),
                    new SqlParameter("@Password", user.Password),
                    new SqlParameter("@FullName", user.FullName),
                    new SqlParameter("@Email", (object)user.Email ?? DBNull.Value)
                };

                object result = DatabaseHelper.ExecuteScalar("sp_RegisterUser", parameters);
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi đăng ký: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Đổi mật khẩu
        /// </summary>
        public static bool ChangePassword(int userID, string oldPasswordHash, string newPasswordHash)
        {
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@UserID", userID),
                    new SqlParameter("@OldPassword", oldPasswordHash),
                    new SqlParameter("@NewPassword", newPasswordHash)
                };

                object result = DatabaseHelper.ExecuteScalar("sp_ChangePassword", parameters);
                return Convert.ToInt32(result) == 1;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi đổi mật khẩu: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Map DataRow sang User object
        /// </summary>
        private static User MapDataRowToUser(DataRow row)
        {
            return new User
            {
                UserID = Convert.ToInt32(row["UserID"]),
                Username = row["Username"].ToString(),
                FullName = row["FullName"].ToString(),
                Email = row["Email"] != DBNull.Value ? row["Email"].ToString() : "",
                LastLoginDate = row["LastLoginDate"] != DBNull.Value ? 
                                (DateTime?)Convert.ToDateTime(row["LastLoginDate"]) : null
            };
        }
    }
}

