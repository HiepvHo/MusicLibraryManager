using System;
using System.Windows.Forms;
using Sunny.UI;
using MusicLibraryManager.BUS;
using MusicLibraryManager.Entities;
using MusicLibraryManager.Helpers;

namespace MusicLibraryManager.GUI
{
    public partial class LoginForm : UIForm
    {
        public User CurrentUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Set focus
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text;

                if (string.IsNullOrWhiteSpace(username))
                {
                    UIHelper.ShowWarning("Vui lòng nhập tên đăng nhập!");
                    txtUsername.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    UIHelper.ShowWarning("Vui lòng nhập mật khẩu!");
                    txtPassword.Focus();
                    return;
                }

                // Hiển thị loading
                btnLogin.Enabled = false;
                btnLogin.Text = "Đang đăng nhập...";
                Application.DoEvents();

                // Đăng nhập
                CurrentUser = UserBUS.Login(username, password);

                if (CurrentUser != null)
                {
                    // Set UserSession
                    UserSession.Login(CurrentUser);
                    
                    // Đăng nhập thành công
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError(ex.Message);
                btnLogin.Enabled = true;
                btnLogin.Text = "🔐 Đăng nhập";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            if (registerForm.ShowDialog() == DialogResult.OK)
            {
                UIHelper.ShowSuccess("Đăng ký thành công! Vui lòng đăng nhập.");
                txtUsername.Text = registerForm.RegisteredUsername;
                txtPassword.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (UIHelper.ShowExitConfirm())
            {
                Application.Exit();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '●';
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            try
            {
                ForgotPasswordForm forgotForm = new ForgotPasswordForm();
                if (forgotForm.ShowDialog() == DialogResult.OK)
                {
                    // Password đã được reset thành công
                    // Có thể tự động điền username nếu muốn
                    UIHelper.ShowSuccess("Đặt lại mật khẩu thành công!\nVui lòng đăng nhập bằng mật khẩu mới.");
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi: {ex.Message}");
            }
        }
    }
}

