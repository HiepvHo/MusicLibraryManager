namespace MusicLibraryManager.GUI
{
    partial class PlayerWindow
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelVideoPlayer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelVideoPlayer
            // 
            this.panelVideoPlayer.BackColor = System.Drawing.Color.Black;
            this.panelVideoPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVideoPlayer.Location = new System.Drawing.Point(0, 35);
            this.panelVideoPlayer.Name = "panelVideoPlayer";
            this.panelVideoPlayer.Size = new System.Drawing.Size(800, 565);
            this.panelVideoPlayer.TabIndex = 0;
            // 
            // PlayerWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelVideoPlayer);
            this.Name = "PlayerWindow";
            this.Text = "Music/Video Player";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 800, 450);
            this.Shown += new System.EventHandler(this.PlayerWindow_Shown);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelVideoPlayer;
    }
}

