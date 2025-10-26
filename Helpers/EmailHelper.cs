using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace MusicLibraryManager.Helpers
{
    /// <summary>
    /// Helper class để gửi email
    /// </summary>
    public static class EmailHelper
    {
        /// <summary>
        /// Gửi email reset password
        /// </summary>
        public static bool SendPasswordResetEmail(string toEmail, string username, string resetToken)
        {
            try
            {
                // Lấy config từ App.config
                string smtpHost = ConfigurationManager.AppSettings["SmtpHost"];
                int smtpPort = Convert.ToInt32(ConfigurationManager.AppSettings["SmtpPort"]);
                string smtpUsername = ConfigurationManager.AppSettings["SmtpUsername"];
                string smtpPassword = ConfigurationManager.AppSettings["SmtpPassword"];
                string fromEmail = ConfigurationManager.AppSettings["SmtpFromEmail"] ?? smtpUsername;
                string fromName = ConfigurationManager.AppSettings["SmtpFromName"] ?? "Music Library Manager";

                // Tạo email
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail, fromName);
                mail.To.Add(toEmail);
                mail.Subject = "🔐 Mã khôi phục mật khẩu - Music Library Manager";
                mail.IsBodyHtml = true;
                
                // Format mã để dễ đọc (thêm dấu gạch ngang)
                string formattedToken = FormatTokenForDisplay(resetToken);
                
                // Nội dung email
                mail.Body = $@"
<!DOCTYPE html>
<html>
<head>
    <style>
        body {{ font-family: 'Segoe UI', Arial, sans-serif; line-height: 1.6; color: #333; }}
        .container {{ max-width: 600px; margin: 0 auto; padding: 20px; }}
        .header {{ background: linear-gradient(135deg, #667eea 0%, #764ba2 100%); color: white; padding: 30px; text-align: center; border-radius: 10px 10px 0 0; }}
        .content {{ background: #f9f9f9; padding: 30px; border-radius: 0 0 10px 10px; }}
        .token-box {{ background: white; border: 2px dashed #667eea; padding: 20px; margin: 20px 0; text-align: center; border-radius: 8px; }}
        .token {{ font-size: 32px; font-weight: bold; color: #667eea; letter-spacing: 3px; font-family: 'Courier New', monospace; }}
        .warning {{ background: #fff3cd; border-left: 4px solid #ffc107; padding: 15px; margin: 20px 0; }}
        .footer {{ text-align: center; color: #888; font-size: 12px; margin-top: 30px; padding-top: 20px; border-top: 1px solid #ddd; }}
        .btn {{ display: inline-block; background: #667eea; color: white; padding: 12px 30px; text-decoration: none; border-radius: 5px; margin: 10px 0; }}
    </style>
</head>
<body>
    <div class=""container"">
        <div class=""header"">
            <h1>🎵 Music Library Manager</h1>
            <p>Khôi phục mật khẩu</p>
        </div>
        <div class=""content"">
            <p>Xin chào <strong>{username}</strong>,</p>
            <p>Chúng tôi nhận được yêu cầu đặt lại mật khẩu cho tài khoản của bạn.</p>
            
            <div class=""token-box"">
                <p style=""margin: 0 0 10px 0; font-size: 14px; color: #666;"">Mã khôi phục của bạn:</p>
                <div class=""token"">{formattedToken}</div>
            </div>
            
            <p>📝 <strong>Hướng dẫn sử dụng:</strong></p>
            <ol>
                <li>Mở ứng dụng Music Library Manager</li>
                <li>Click vào ""Quên mật khẩu?""</li>
                <li>Nhập mã khôi phục ở trên</li>
                <li>Đặt mật khẩu mới của bạn</li>
            </ol>
            
            <div class=""warning"">
                <strong>⚠️ Lưu ý:</strong>
                <ul style=""margin: 5px 0;"">
                    <li>Mã này có hiệu lực trong <strong>30 phút</strong></li>
                    <li>Chỉ sử dụng được <strong>một lần</strong></li>
                    <li>Không chia sẻ mã này với bất kỳ ai</li>
                </ul>
            </div>
            
            <p style=""margin-top: 30px;"">Nếu bạn không yêu cầu đặt lại mật khẩu, vui lòng bỏ qua email này. Tài khoản của bạn vẫn an toàn.</p>
        </div>
        <div class=""footer"">
            <p>Email này được gửi tự động, vui lòng không trả lời.</p>
            <p>&copy; 2025 Music Library Manager. All rights reserved.</p>
        </div>
    </div>
</body>
</html>";

                // Configure SMTP
                SmtpClient smtp = new SmtpClient(smtpHost, smtpPort);
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                smtp.Timeout = 30000; // 30 seconds

                // Gửi email
                smtp.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Email error: {ex.Message}");
                throw new Exception($"Không thể gửi email: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Format token để dễ đọc (thêm dấu gạch ngang mỗi 4 ký tự)
        /// VD: A1B2C3D4E5F6 → A1B2-C3D4-E5F6
        /// </summary>
        private static string FormatTokenForDisplay(string token)
        {
            // Lấy 12 ký tự đầu của GUID và format
            string shortToken = token.Replace("-", "").Substring(0, Math.Min(12, token.Length)).ToUpper();
            
            // Thêm dấu gạch ngang mỗi 4 ký tự
            string formatted = "";
            for (int i = 0; i < shortToken.Length; i++)
            {
                if (i > 0 && i % 4 == 0)
                    formatted += "-";
                formatted += shortToken[i];
            }
            
            return formatted;
        }

        /// <summary>
        /// Test kết nối SMTP
        /// </summary>
        public static bool TestSmtpConnection()
        {
            try
            {
                string smtpHost = ConfigurationManager.AppSettings["SmtpHost"];
                int smtpPort = Convert.ToInt32(ConfigurationManager.AppSettings["SmtpPort"]);
                string smtpUsername = ConfigurationManager.AppSettings["SmtpUsername"];
                string smtpPassword = ConfigurationManager.AppSettings["SmtpPassword"];

                using (SmtpClient smtp = new SmtpClient(smtpHost, smtpPort))
                {
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                    smtp.Timeout = 10000;
                    
                    // Không gửi email, chỉ test connection
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"SMTP test failed: {ex.Message}");
                return false;
            }
        }
    }
}

