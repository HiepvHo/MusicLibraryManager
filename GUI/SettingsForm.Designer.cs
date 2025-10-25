namespace MusicLibraryManager.GUI
{
    partial class SettingsForm
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
            this.lblTheme = new Sunny.UI.UILabel();
            this.cboTheme = new Sunny.UI.UIComboBox();
            this.lblMusicFolder = new Sunny.UI.UILabel();
            this.txtMusicFolder = new Sunny.UI.UITextBox();
            this.btnBrowseFolder = new Sunny.UI.UISymbolButton();
            this.btnSave = new Sunny.UI.UIButton();
            this.btnCancel = new Sunny.UI.UIButton();
            this.lblTitle = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // lblTheme
            // 
            this.lblTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTheme.Location = new System.Drawing.Point(30, 91);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(150, 30);
            this.lblTheme.TabIndex = 0;
            this.lblTheme.Text = "Giao diện:";
            this.lblTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboTheme
            // 
            this.cboTheme.DataSource = null;
            this.cboTheme.FillColor = System.Drawing.Color.White;
            this.cboTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cboTheme.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboTheme.Items.AddRange(new object[] {
            "Light (Sáng)",
            "Dark (Tối)"});
            this.cboTheme.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboTheme.Location = new System.Drawing.Point(200, 91);
            this.cboTheme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTheme.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboTheme.Name = "cboTheme";
            this.cboTheme.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboTheme.Size = new System.Drawing.Size(350, 35);
            this.cboTheme.SymbolSize = 24;
            this.cboTheme.TabIndex = 1;
            this.cboTheme.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboTheme.Watermark = "";
            // 
            // lblMusicFolder
            // 
            this.lblMusicFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblMusicFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblMusicFolder.Location = new System.Drawing.Point(30, 151);
            this.lblMusicFolder.Name = "lblMusicFolder";
            this.lblMusicFolder.Size = new System.Drawing.Size(150, 30);
            this.lblMusicFolder.TabIndex = 2;
            this.lblMusicFolder.Text = "Thư mục nhạc:";
            this.lblMusicFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMusicFolder
            // 
            this.txtMusicFolder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMusicFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMusicFolder.Location = new System.Drawing.Point(200, 151);
            this.txtMusicFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMusicFolder.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMusicFolder.Name = "txtMusicFolder";
            this.txtMusicFolder.Padding = new System.Windows.Forms.Padding(5);
            this.txtMusicFolder.ReadOnly = true;
            this.txtMusicFolder.ShowText = false;
            this.txtMusicFolder.Size = new System.Drawing.Size(290, 35);
            this.txtMusicFolder.TabIndex = 3;
            this.txtMusicFolder.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMusicFolder.Watermark = "";
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBrowseFolder.Location = new System.Drawing.Point(500, 151);
            this.btnBrowseFolder.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(50, 35);
            this.btnBrowseFolder.Symbol = 61563;
            this.btnBrowseFolder.TabIndex = 4;
            this.btnBrowseFolder.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSave.Location = new System.Drawing.Point(200, 231);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 45);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "💾 Lưu";
            this.btnSave.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCancel.Location = new System.Drawing.Point(370, 231);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 45);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "❌ Hủy";
            this.btnCancel.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTitle.Location = new System.Drawing.Point(29, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 40);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "⚙️ CÀI ĐẶT";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(600, 320);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowseFolder);
            this.Controls.Add(this.txtMusicFolder);
            this.Controls.Add(this.lblMusicFolder);
            this.Controls.Add(this.cboTheme);
            this.Controls.Add(this.lblTheme);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cài đặt";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 600, 320);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel lblTheme;
        private Sunny.UI.UIComboBox cboTheme;
        private Sunny.UI.UILabel lblMusicFolder;
        private Sunny.UI.UITextBox txtMusicFolder;
        private Sunny.UI.UISymbolButton btnBrowseFolder;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UIButton btnCancel;
        private Sunny.UI.UILabel lblTitle;
    }
}

