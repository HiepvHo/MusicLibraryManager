namespace MusicLibraryManager.GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSidebar = new Sunny.UI.UIPanel();
            this.btnSettings = new Sunny.UI.UIButton();
            this.btnStatistics = new Sunny.UI.UIButton();
            this.btnPlaylists = new Sunny.UI.UIButton();
            this.btnArtists = new Sunny.UI.UIButton();
            this.btnSongs = new Sunny.UI.UIButton();
            this.lblAppTitle = new Sunny.UI.UILabel();
            this.pnlContent = new Sunny.UI.UIPanel();
            this.pnlHeader = new Sunny.UI.UIPanel();
            this.btnLogout = new Sunny.UI.UISymbolButton();
            this.btnToggleTheme = new Sunny.UI.UISymbolButton();
            this.lblWelcome = new Sunny.UI.UILabel();
            this.playerControl = new MusicLibraryManager.GUI.MusicPlayerControl();
            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.pnlSidebar.Controls.Add(this.btnSettings);
            this.pnlSidebar.Controls.Add(this.btnStatistics);
            this.pnlSidebar.Controls.Add(this.btnPlaylists);
            this.pnlSidebar.Controls.Add(this.btnArtists);
            this.pnlSidebar.Controls.Add(this.btnSongs);
            this.pnlSidebar.Controls.Add(this.lblAppTitle);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 35);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSidebar.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(250, 848);
            this.pnlSidebar.TabIndex = 0;
            this.pnlSidebar.Text = null;
            this.pnlSidebar.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(0, 788);
            this.btnSettings.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(250, 60);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "⚙️ Cài đặt";
            this.btnSettings.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.Transparent;
            this.btnStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistics.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.Location = new System.Drawing.Point(0, 331);
            this.btnStatistics.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(250, 72);
            this.btnStatistics.TabIndex = 4;
            this.btnStatistics.Text = "📊 Thống kê";
            this.btnStatistics.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnPlaylists
            // 
            this.btnPlaylists.BackColor = System.Drawing.Color.Transparent;
            this.btnPlaylists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylists.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaylists.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylists.Location = new System.Drawing.Point(0, 262);
            this.btnPlaylists.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPlaylists.Name = "btnPlaylists";
            this.btnPlaylists.Size = new System.Drawing.Size(250, 69);
            this.btnPlaylists.TabIndex = 3;
            this.btnPlaylists.Text = "🎵 Playlist";
            this.btnPlaylists.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPlaylists.Click += new System.EventHandler(this.btnPlaylists_Click);
            // 
            // btnArtists
            // 
            this.btnArtists.BackColor = System.Drawing.Color.Transparent;
            this.btnArtists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArtists.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArtists.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtists.Location = new System.Drawing.Point(0, 194);
            this.btnArtists.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnArtists.Name = "btnArtists";
            this.btnArtists.Size = new System.Drawing.Size(250, 68);
            this.btnArtists.TabIndex = 2;
            this.btnArtists.Text = "🎤 Ca sĩ & Thể loại";
            this.btnArtists.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnArtists.Click += new System.EventHandler(this.btnArtists_Click);
            // 
            // btnSongs
            // 
            this.btnSongs.BackColor = System.Drawing.Color.Transparent;
            this.btnSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSongs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSongs.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSongs.Location = new System.Drawing.Point(0, 124);
            this.btnSongs.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSongs.Name = "btnSongs";
            this.btnSongs.Size = new System.Drawing.Size(250, 70);
            this.btnSongs.TabIndex = 1;
            this.btnSongs.Text = "🎧 Quản lý bài hát";
            this.btnSongs.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSongs.Click += new System.EventHandler(this.btnSongs_Click);
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.BackColor = System.Drawing.Color.DimGray;
            this.lblAppTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(0, 0);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(250, 124);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "🎵 Music Library\r\nManager";
            this.lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlContent.Location = new System.Drawing.Point(250, 95);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlContent.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1319, 688);
            this.pnlContent.TabIndex = 1;
            this.pnlContent.Text = null;
            this.pnlContent.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Controls.Add(this.btnToggleTheme);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlHeader.Location = new System.Drawing.Point(250, 35);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHeader.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1319, 60);
            this.pnlHeader.TabIndex = 2;
            this.pnlHeader.Text = null;
            this.pnlHeader.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.Location = new System.Drawing.Point(1109, 10);
            this.btnLogout.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(110, 40);
            this.btnLogout.Symbol = 61584;
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnToggleTheme
            // 
            this.btnToggleTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleTheme.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnToggleTheme.Location = new System.Drawing.Point(1239, 10);
            this.btnToggleTheme.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnToggleTheme.Name = "btnToggleTheme";
            this.btnToggleTheme.Size = new System.Drawing.Size(60, 40);
            this.btnToggleTheme.Symbol = 61819;
            this.btnToggleTheme.TabIndex = 1;
            this.btnToggleTheme.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnToggleTheme.Click += new System.EventHandler(this.btnToggleTheme_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblWelcome.Location = new System.Drawing.Point(20, 10);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(600, 40);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Chào mừng đến với Music Library Manager";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playerControl
            // 
            this.playerControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.playerControl.Location = new System.Drawing.Point(250, 783);
            this.playerControl.Name = "playerControl";
            this.playerControl.Size = new System.Drawing.Size(1319, 100);
            this.playerControl.TabIndex = 3;
            this.playerControl.Load += new System.EventHandler(this.playerControl_Load);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1569, 883);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.playerControl);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "MainForm";
            this.Text = "Music Library Manager";
            this.TitleFont = new System.Drawing.Font("Segoe UI", 12F);
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 1400, 850);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel pnlSidebar;
        private Sunny.UI.UILabel lblAppTitle;
        private Sunny.UI.UIButton btnSongs;
        private Sunny.UI.UIButton btnArtists;
        private Sunny.UI.UIButton btnPlaylists;
        private Sunny.UI.UIButton btnStatistics;
        private Sunny.UI.UIButton btnSettings;
        private Sunny.UI.UIPanel pnlContent;
        private Sunny.UI.UIPanel pnlHeader;
        private Sunny.UI.UILabel lblWelcome;
        private Sunny.UI.UISymbolButton btnToggleTheme;
        private Sunny.UI.UISymbolButton btnLogout;
        private MusicPlayerControl playerControl;
    }
}

