using System;
using System.Windows.Forms;
using Sunny.UI;
using MusicLibraryManager.BUS;
using MusicLibraryManager.Helpers;

namespace MusicLibraryManager.GUI
{
    public partial class RegisterForm : UIForm
    {
        public string RegisteredUsername { get; private set; }

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text;
                string confirmPassword = txtConfirmPassword.Text;
                string fullName = txtFullName.Text.Trim();
                string email = txtEmail.Text.Trim();

                // Validation
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

                if (password != confirmPassword)
                {
                    UIHelper.ShowWarning("Mật khẩu xác nhận không khớp!");
                    txtConfirmPassword.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(fullName))
                {
                    UIHelper.ShowWarning("Vui lòng nhập họ tên!");
                    txtFullName.Focus();
                    return;
                }

                // Đăng ký
                int userID = UserBUS.RegisterUser(username, password, fullName, email);

                if (userID > 0)
                {
                    RegisteredUsername = username;
                    UIHelper.ShowSuccess($"Đăng ký thành công!\nUser ID: {userID}");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '●';
            txtConfirmPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '●';
        }
    }
}

