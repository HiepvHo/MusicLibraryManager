using System;
using System.Windows.Forms;
using Sunny.UI;
using MusicLibraryManager.BUS;
using MusicLibraryManager.Helpers;

namespace MusicLibraryManager.GUI
{
    public partial class ForgotPasswordForm : UIForm
    {
        private string currentEmail = "";
        
        public ForgotPasswordForm()
        {
            InitializeComponent();
            ShowStep1(); // Bắt đầu với bước 1: Nhập email
        }

        /// <summary>
        /// Hiển thị bước 1: Nhập email
        /// </summary>
        private void ShowStep1()
        {
            pnlStep1.Visible = true;
            pnlStep1.BringToFront();
            pnlStep2.Visible = false;
            
            txtEmail.Focus();
        }

        /// <summary>
        /// Hiển thị bước 2: Nhập token + password mới
        /// </summary>
        private void ShowStep2()
        {
            pnlStep1.Visible = false;
            pnlStep2.Visible = true;
            pnlStep2.BringToFront();
            
            lblEmailSent.Text = $"✅ Mã khôi phục đã được gửi đến {currentEmail}";
            txtToken.Focus();
        }

        /// <summary>
        /// Button: Gửi mã khôi phục
        /// </summary>
        private void btnSendCode_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();

                if (string.IsNullOrWhiteSpace(email))
                {
                    UIHelper.ShowWarning("Vui lòng nhập địa chỉ email!");
                    txtEmail.Focus();
                    return;
                }

                // Show loading
                btnSendCode.Enabled = false;
                btnSendCode.Text = "Đang gửi...";
                Application.DoEvents();

                // Gửi email
                bool success = PasswordResetBUS.RequestPasswordReset(email);

                if (success)
                {
                    currentEmail = email;
                    UIHelper.ShowSuccess(
                        $"Mã khôi phục đã được gửi đến {email}!\n\n" +
                        "Vui lòng kiểm tra hộp thư (và cả thư mục Spam).\n" +
                        "Mã có hiệu lực trong 30 phút."
                    );
                    ShowStep2();
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError(ex.Message);
            }
            finally
            {
                btnSendCode.Enabled = true;
                btnSendCode.Text = "Gửi mã khôi phục";
            }
        }

        /// <summary>
        /// Button: Đặt lại mật khẩu
        /// </summary>
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                string token = txtToken.Text.Trim();
                string newPassword = txtNewPassword.Text;
                string confirmPassword = txtConfirmPassword.Text;

                // Validate
                if (string.IsNullOrWhiteSpace(token))
                {
                    UIHelper.ShowWarning("Vui lòng nhập mã khôi phục!");
                    txtToken.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(newPassword))
                {
                    UIHelper.ShowWarning("Vui lòng nhập mật khẩu mới!");
                    txtNewPassword.Focus();
                    return;
                }

                if (newPassword.Length < 6)
                {
                    UIHelper.ShowWarning("Mật khẩu phải có ít nhất 6 ký tự!");
                    txtNewPassword.Focus();
                    return;
                }

                if (newPassword != confirmPassword)
                {
                    UIHelper.ShowWarning("Mật khẩu xác nhận không khớp!");
                    txtConfirmPassword.Focus();
                    return;
                }

                // Show loading
                btnResetPassword.Enabled = false;
                btnResetPassword.Text = "Đang xử lý...";
                Application.DoEvents();

                // Reset password
                bool success = PasswordResetBUS.ResetPasswordWithToken(token, newPassword);

                if (success)
                {
                    UIHelper.ShowSuccess(
                        "✅ Đặt lại mật khẩu thành công!\n\n" +
                        "Bạn có thể đăng nhập bằng mật khẩu mới ngay bây giờ."
                    );
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError(ex.Message);
            }
            finally
            {
                btnResetPassword.Enabled = true;
                btnResetPassword.Text = "Đặt lại mật khẩu";
            }
        }

        /// <summary>
        /// Button: Quay lại bước 1
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowStep1();
            
            // Clear step 2
            txtToken.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
        }

        /// <summary>
        /// Button: Hủy bỏ
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Link: Gửi lại mã
        /// </summary>
        private void lblResendCode_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentEmail))
            {
                if (UIHelper.ShowConfirm($"Gửi lại mã khôi phục đến {currentEmail}?"))
                {
                    txtEmail.Text = currentEmail;
                    ShowStep1();
                    btnSendCode_Click(sender, e);
                }
            }
        }

        /// <summary>
        /// Checkbox: Hiển thị/ẩn mật khẩu
        /// </summary>
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool show = chkShowPassword.Checked;
            txtNewPassword.PasswordChar = show ? '\0' : '●';
            txtConfirmPassword.PasswordChar = show ? '\0' : '●';
        }

        /// <summary>
        /// Form load
        /// </summary>
        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            // Set password char
            txtNewPassword.PasswordChar = '●';
            txtConfirmPassword.PasswordChar = '●';
        }
    }
}

