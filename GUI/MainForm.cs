using System;
using System.Windows.Forms;
using Sunny.UI;
using MusicLibraryManager.BUS;
using MusicLibraryManager.DAL;
using MusicLibraryManager.Entities;
using MusicLibraryManager.Helpers;

namespace MusicLibraryManager.GUI
{
    public partial class MainForm : UIForm
    {
        public User CurrentUser { get; set; }

        public MainForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
            LoadTheme();
        }

        public MainForm(User user) : this()
        {
            CurrentUser = user;
            UpdateUserInfo();
        }

        private void InitializeCustomComponents()
        {
            // Load theme từ settings
            string theme = SettingBUS.GetTheme();
            ApplyTheme(theme);
        }

        private void UpdateUserInfo()
        {
            if (CurrentUser != null)
            {
                lblWelcome.Text = $"Xin chào, {CurrentUser.FullName}!";
                btnLogout.Visible = true;
            }
            else
            {
                lblWelcome.Text = "Chào mừng đến với Music Library Manager";
                btnLogout.Visible = false;
            }
        }

        private void LoadTheme()
        {
            string theme = SettingBUS.GetTheme();
            if (theme == "Dark")
            {
                Style = UIStyle.Black;
            }
            else
            {
                Style = UIStyle.Blue;
            }
        }

        public void ApplyTheme(string theme)
        {
            if (theme == "Dark")
            {
                Style = UIStyle.Black;
            }
            else
            {
                Style = UIStyle.Blue;
            }
            SettingBUS.SetTheme(theme);
        }

        // Navigation methods
        public void ShowSongManagement()
        {
            OpenChildForm(new SongManagementForm());
        }

        public void ShowArtistManagement()
        {
            OpenChildForm(new ArtistGenreManagementForm());
        }

        public void ShowPlaylistManagement()
        {
            OpenChildForm(new PlaylistManagementForm());
        }

        public void ShowStatistics()
        {
            OpenChildForm(new StatisticsForm());
        }

        public void ShowHistory()
        {
            OpenChildForm(new HistoryForm());
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Test database connection
            if (!DatabaseHelper.TestConnection())
            {
                UIHelper.ShowError("Không thể kết nối đến database!\nVui lòng kiểm tra lại cấu hình.");
                Application.Exit();
            }

            // Load trang chủ mặc định
            ShowSongManagement();
        }

        private void btnSongs_Click(object sender, EventArgs e)
        {
            ShowSongManagement();
        }

        private void btnArtists_Click(object sender, EventArgs e)
        {
            ShowArtistManagement();
        }

        private void btnPlaylists_Click(object sender, EventArgs e)
        {
            ShowPlaylistManagement();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            ShowHistory();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            ShowStatistics();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.ShowDialog();
        }

        private void btnToggleTheme_Click(object sender, EventArgs e)
        {
            string currentTheme = SettingBUS.GetTheme();
            string newTheme = currentTheme == "Light" ? "Dark" : "Light";
            ApplyTheme(newTheme);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (UIHelper.ShowLogoutConfirm())
            {
                // Đăng xuất và clear session
                UserSession.Logout();
                this.Hide();
                
                LoginForm loginForm = new LoginForm();
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Đăng nhập lại thành công
                    CurrentUser = UserSession.CurrentUser;
                    UpdateUserInfo();
                    this.Show();
                }
                else
                {
                    // Đóng ứng dụng nếu không đăng nhập lại
                    Application.Exit();
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cleanup if needed
        }

        private void playerControl_Load(object sender, EventArgs e)
        {

        }
    }
}

