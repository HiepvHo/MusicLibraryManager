namespace MusicLibraryManager.GUI
{
    partial class MusicPlayerControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerControl));
            this.panelPlayer = new Sunny.UI.UIPanel();
            this.btnOpenPlayer = new Sunny.UI.UISymbolButton();
            this.lblVolume = new Sunny.UI.UILabel();
            this.trackVolume = new Sunny.UI.UITrackBar();
            this.btnShuffle = new Sunny.UI.UISymbolButton();
            this.btnRepeat = new Sunny.UI.UISymbolButton();
            this.lblDuration = new Sunny.UI.UILabel();
            this.lblCurrentTime = new Sunny.UI.UILabel();
            this.trackProgress = new Sunny.UI.UITrackBar();
            this.lblArtist = new Sunny.UI.UILabel();
            this.lblSongTitle = new Sunny.UI.UILabel();
            this.btnNext = new Sunny.UI.UISymbolButton();
            this.btnPrevious = new Sunny.UI.UISymbolButton();
            this.btnStop = new Sunny.UI.UISymbolButton();
            this.btnPlay = new Sunny.UI.UISymbolButton();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.panelPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPlayer
            // 
            this.panelPlayer.Controls.Add(this.btnOpenPlayer);
            this.panelPlayer.Controls.Add(this.lblVolume);
            this.panelPlayer.Controls.Add(this.trackVolume);
            this.panelPlayer.Controls.Add(this.btnShuffle);
            this.panelPlayer.Controls.Add(this.btnRepeat);
            this.panelPlayer.Controls.Add(this.lblDuration);
            this.panelPlayer.Controls.Add(this.lblCurrentTime);
            this.panelPlayer.Controls.Add(this.trackProgress);
            this.panelPlayer.Controls.Add(this.lblArtist);
            this.panelPlayer.Controls.Add(this.lblSongTitle);
            this.panelPlayer.Controls.Add(this.btnNext);
            this.panelPlayer.Controls.Add(this.btnPrevious);
            this.panelPlayer.Controls.Add(this.btnStop);
            this.panelPlayer.Controls.Add(this.btnPlay);
            this.panelPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panelPlayer.Location = new System.Drawing.Point(0, 0);
            this.panelPlayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelPlayer.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(1200, 100);
            this.panelPlayer.TabIndex = 0;
            this.panelPlayer.Text = null;
            this.panelPlayer.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenPlayer
            // 
            this.btnOpenPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOpenPlayer.Location = new System.Drawing.Point(1130, 10);
            this.btnOpenPlayer.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOpenPlayer.Name = "btnOpenPlayer";
            this.btnOpenPlayer.Size = new System.Drawing.Size(50, 35);
            this.btnOpenPlayer.Symbol = 61515;
            this.btnOpenPlayer.TabIndex = 13;
            this.btnOpenPlayer.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOpenPlayer.Visible = false;
            this.btnOpenPlayer.Click += new System.EventHandler(this.btnOpenPlayer_Click);
            // 
            // lblVolume
            // 
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblVolume.Location = new System.Drawing.Point(1050, 55);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(50, 23);
            this.lblVolume.TabIndex = 12;
            this.lblVolume.Text = "100%";
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trackVolume
            // 
            this.trackVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.trackVolume.Location = new System.Drawing.Point(940, 55);
            this.trackVolume.Maximum = 100;
            this.trackVolume.MinimumSize = new System.Drawing.Size(1, 1);
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(100, 29);
            this.trackVolume.TabIndex = 11;
            this.trackVolume.Text = "uiTrackBar1";
            this.trackVolume.Value = 50;
            this.trackVolume.ValueChanged += new System.EventHandler(this.trackVolume_ValueChanged);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnShuffle.Location = new System.Drawing.Point(665, 10);
            this.btnShuffle.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(45, 35);
            this.btnShuffle.Symbol = 61518;
            this.btnShuffle.TabIndex = 10;
            this.btnShuffle.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnShuffle.Visible = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnRepeat
            // 
            this.btnRepeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRepeat.Location = new System.Drawing.Point(720, 10);
            this.btnRepeat.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(45, 35);
            this.btnRepeat.Symbol = 61467;
            this.btnRepeat.TabIndex = 9;
            this.btnRepeat.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRepeat.Visible = false;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // lblDuration
            // 
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDuration.Location = new System.Drawing.Point(860, 55);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(60, 23);
            this.lblDuration.TabIndex = 8;
            this.lblDuration.Text = "00:00";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCurrentTime.Location = new System.Drawing.Point(280, 55);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(60, 23);
            this.lblCurrentTime.TabIndex = 7;
            this.lblCurrentTime.Text = "00:00";
            this.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trackProgress
            // 
            this.trackProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.trackProgress.Location = new System.Drawing.Point(350, 55);
            this.trackProgress.Maximum = 100;
            this.trackProgress.MinimumSize = new System.Drawing.Size(1, 1);
            this.trackProgress.Name = "trackProgress";
            this.trackProgress.Size = new System.Drawing.Size(500, 29);
            this.trackProgress.TabIndex = 6;
            this.trackProgress.Text = "uiTrackBar1";
            this.trackProgress.ValueChanged += new System.EventHandler(this.trackProgress_ValueChanged);
            this.trackProgress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackProgress_MouseDown);
            this.trackProgress.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackProgress_MouseUp);
            // 
            // lblArtist
            // 
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblArtist.ForeColor = System.Drawing.Color.Gray;
            this.lblArtist.Location = new System.Drawing.Point(20, 35);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(250, 23);
            this.lblArtist.TabIndex = 5;
            this.lblArtist.Text = "Unknown Artist";
            this.lblArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSongTitle
            // 
            this.lblSongTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblSongTitle.Location = new System.Drawing.Point(20, 10);
            this.lblSongTitle.Name = "lblSongTitle";
            this.lblSongTitle.Size = new System.Drawing.Size(250, 23);
            this.lblSongTitle.TabIndex = 4;
            this.lblSongTitle.Text = "No song playing";
            this.lblSongTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNext.Location = new System.Drawing.Point(610, 10);
            this.btnNext.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 35);
            this.btnNext.Symbol = 61515; // Next track icon
            this.btnNext.TabIndex = 3;
            this.btnNext.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPrevious.Location = new System.Drawing.Point(500, 10);
            this.btnPrevious.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(45, 35);
            this.btnPrevious.Symbol = 61514; // Previous track icon
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStop.Location = new System.Drawing.Point(610, 10);
            this.btnStop.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(45, 35);
            this.btnStop.Symbol = 61516;
            this.btnStop.TabIndex = 1;
            this.btnStop.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPlay.Location = new System.Drawing.Point(555, 10);
            this.btnPlay.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(45, 35);
            this.btnPlay.Symbol = 61764; // Play icon
            this.btnPlay.TabIndex = 0;
            this.btnPlay.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // timerProgress
            // 
            this.timerProgress.Interval = 500;
            this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick);
            // 
            // MusicPlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPlayer);
            this.Name = "MusicPlayerControl";
            this.Size = new System.Drawing.Size(1200, 100);
            this.panelPlayer.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel panelPlayer;
        private Sunny.UI.UISymbolButton btnPlay;
        private Sunny.UI.UISymbolButton btnStop;
        private Sunny.UI.UISymbolButton btnPrevious;
        private Sunny.UI.UISymbolButton btnNext;
        private Sunny.UI.UILabel lblSongTitle;
        private Sunny.UI.UILabel lblArtist;
        private Sunny.UI.UITrackBar trackProgress;
        private Sunny.UI.UILabel lblCurrentTime;
        private Sunny.UI.UILabel lblDuration;
        private Sunny.UI.UISymbolButton btnRepeat;
        private Sunny.UI.UISymbolButton btnShuffle;
        private Sunny.UI.UITrackBar trackVolume;
        private Sunny.UI.UILabel lblVolume;
        private Sunny.UI.UISymbolButton btnOpenPlayer;
        private System.Windows.Forms.Timer timerProgress;
    }
}

