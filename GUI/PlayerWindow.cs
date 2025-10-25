using System;
using System.Windows.Forms;
using Sunny.UI;

namespace MusicLibraryManager.GUI
{
    public partial class PlayerWindow : UIForm
    {
        private MusicPlayerControl playerControl;
        private AxWMPLib.AxWindowsMediaPlayer wmpPlayer;

        public PlayerWindow(MusicPlayerControl control)
        {
            InitializeComponent();
            playerControl = control;
            wmpPlayer = playerControl.GetMediaPlayer();
            
            // Hiển thị player trong window này
            ShowMediaPlayer();
        }

        private void ShowMediaPlayer()
        {
            try
            {
                // Nếu player đã có trong panel, không cần làm gì
                if (panelVideoPlayer.Controls.Contains(wmpPlayer))
                {
                    wmpPlayer.Refresh();
                    return;
                }

                // Remove từ player control cũ
                if (playerControl.Controls.Contains(wmpPlayer))
                {
                    playerControl.Controls.Remove(wmpPlayer);
                }

                // Suspend layout để tránh flicker
                panelVideoPlayer.SuspendLayout();

                // Cấu hình lại player cho video window
                ((System.ComponentModel.ISupportInitialize)(wmpPlayer)).BeginInit();
                wmpPlayer.uiMode = "full"; // Hiển thị đầy đủ controls
                wmpPlayer.Dock = DockStyle.Fill;
                wmpPlayer.Visible = true;
                wmpPlayer.stretchToFit = true; // Giãn video ra full màn hình
                wmpPlayer.enableContextMenu = true;
                
                // Enable các chức năng tua video
                wmpPlayer.settings.enableErrorDialogs = true;
                wmpPlayer.settings.autoStart = true; // Cho phép autostart để load metadata
                wmpPlayer.settings.setMode("loop", false);
                
                // Cho phép thay đổi kích thước display (quan trọng cho seeking)
                try 
                { 
                    wmpPlayer.settings.invokeURLs = false;
                }
                catch { }
                
                ((System.ComponentModel.ISupportInitialize)(wmpPlayer)).EndInit();

                // Add vào panel video
                panelVideoPlayer.Controls.Add(wmpPlayer);
                
                // Resume layout và refresh
                panelVideoPlayer.ResumeLayout();
                panelVideoPlayer.PerformLayout();
                
                // Refresh để hiển thị
                wmpPlayer.Refresh();
                panelVideoPlayer.Refresh();
                this.Refresh();
                
                // Force process events
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở player window: {ex.Message}");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Không dispose player, chỉ ẩn
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                
                try
                {
                    // Remove khỏi video panel
                    if (panelVideoPlayer.Controls.Contains(wmpPlayer))
                    {
                        panelVideoPlayer.Controls.Remove(wmpPlayer);
                    }

                    // Trả player về player bar
                    ((System.ComponentModel.ISupportInitialize)(wmpPlayer)).BeginInit();
                    wmpPlayer.uiMode = "none";
                    wmpPlayer.Visible = false;
                    wmpPlayer.Dock = DockStyle.None;
                    wmpPlayer.Size = new System.Drawing.Size(0, 0);
                    wmpPlayer.stretchToFit = false; // Reset về không stretch
                    ((System.ComponentModel.ISupportInitialize)(wmpPlayer)).EndInit();

                    // Add lại vào player control
                    if (!playerControl.Controls.Contains(wmpPlayer))
                    {
                        playerControl.Controls.Add(wmpPlayer);
                    }
                }
                catch { }
            }
            
            base.OnFormClosing(e);
        }

        private void PlayerWindow_Shown(object sender, EventArgs e)
        {
            // Đảm bảo player hiển thị đúng
            // Mỗi lần show lại, cần re-init player
            ShowMediaPlayer();
        }
        
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            
            // Khi window được hiển thị lại (từ hidden), cần re-init player
            if (this.Visible)
            {
                ShowMediaPlayer();
            }
        }
    }
}

