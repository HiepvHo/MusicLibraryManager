using System;
using System.Windows.Forms;
using Sunny.UI;
using MusicLibraryManager.BUS;
using MusicLibraryManager.Helpers;

namespace MusicLibraryManager.GUI
{
    public partial class SettingsForm : UIForm
    {
        private MainForm mainForm;

        public SettingsForm(MainForm parent)
        {
            InitializeComponent();
            mainForm = parent;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings()
        {
            try
            {
                // Load theme
                string theme = SettingBUS.GetTheme();
                cboTheme.SelectedIndex = theme == "Dark" ? 1 : 0;

                // Load other settings
                txtMusicFolder.Text = SettingBUS.GetDefaultMusicFolder();
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi khi tải cài đặt: {ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Save theme
                string theme = cboTheme.SelectedIndex == 1 ? "Dark" : "Light";
                SettingBUS.SetTheme(theme);

                // Apply theme immediately
                if (mainForm != null)
                {
                    mainForm.ApplyTheme(theme);
                }

                // Save music folder
                if (!string.IsNullOrWhiteSpace(txtMusicFolder.Text))
                {
                    SettingBUS.SetDefaultMusicFolder(txtMusicFolder.Text);
                }

                UIHelper.ShowSuccess("Đã lưu cài đặt thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi khi lưu cài đặt: {ex.Message}");
            }
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Chọn thư mục nhạc mặc định";
                fbd.SelectedPath = txtMusicFolder.Text;
                
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtMusicFolder.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

