namespace MusicLibraryManager.GUI
{
    partial class StatisticsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new Sunny.UI.UIPanel();
            this.btnRefresh = new Sunny.UI.UISymbolButton();
            this.lblPlaylistCount = new Sunny.UI.UILabel();
            this.lblFavoriteCount = new Sunny.UI.UILabel();
            this.lblTotalSongs = new Sunny.UI.UILabel();
            this.lblTitle = new Sunny.UI.UILabel();
            this.tabControl = new Sunny.UI.UITabControl();
            this.tabGenreStats = new System.Windows.Forms.TabPage();
            this.dgvGenreStats = new Sunny.UI.UIDataGridView();
            this.tabTopSongs = new System.Windows.Forms.TabPage();
            this.dgvTopSongs = new Sunny.UI.UIDataGridView();
            this.tabFavorites = new System.Windows.Forms.TabPage();
            this.dgvFavorites = new Sunny.UI.UIDataGridView();
            this.pnlTop.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabGenreStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenreStats)).BeginInit();
            this.tabTopSongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSongs)).BeginInit();
            this.tabFavorites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavorites)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnRefresh);
            this.pnlTop.Controls.Add(this.lblPlaylistCount);
            this.pnlTop.Controls.Add(this.lblFavoriteCount);
            this.pnlTop.Controls.Add(this.lblTotalSongs);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlTop.Location = new System.Drawing.Point(0, 35);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1167, 120);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.Text = null;
            this.pnlTop.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRefresh.Location = new System.Drawing.Point(1006, 70);
            this.btnRefresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(124, 35);
            this.btnRefresh.Symbol = 61473;
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblPlaylistCount
            // 
            this.lblPlaylistCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPlaylistCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblPlaylistCount.Location = new System.Drawing.Point(750, 75);
            this.lblPlaylistCount.Name = "lblPlaylistCount";
            this.lblPlaylistCount.Size = new System.Drawing.Size(250, 30);
            this.lblPlaylistCount.TabIndex = 3;
            this.lblPlaylistCount.Text = "Số playlist: 0";
            this.lblPlaylistCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFavoriteCount
            // 
            this.lblFavoriteCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFavoriteCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblFavoriteCount.Location = new System.Drawing.Point(400, 75);
            this.lblFavoriteCount.Name = "lblFavoriteCount";
            this.lblFavoriteCount.Size = new System.Drawing.Size(300, 30);
            this.lblFavoriteCount.TabIndex = 2;
            this.lblFavoriteCount.Text = "Bài hát yêu thích: 0";
            this.lblFavoriteCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalSongs
            // 
            this.lblTotalSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTotalSongs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTotalSongs.Location = new System.Drawing.Point(30, 75);
            this.lblTotalSongs.Name = "lblTotalSongs";
            this.lblTotalSongs.Size = new System.Drawing.Size(300, 30);
            this.lblTotalSongs.TabIndex = 1;
            this.lblTotalSongs.Text = "Tổng số bài hát: 0";
            this.lblTotalSongs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📊 THỐNG KÊ & BÁO CÁO";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGenreStats);
            this.tabControl.Controls.Add(this.tabTopSongs);
            this.tabControl.Controls.Add(this.tabFavorites);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl.ItemSize = new System.Drawing.Size(250, 40);
            this.tabControl.Location = new System.Drawing.Point(0, 155);
            this.tabControl.MainPage = "";
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1167, 628);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 1;
            this.tabControl.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // tabGenreStats
            // 
            this.tabGenreStats.BackColor = System.Drawing.Color.White;
            this.tabGenreStats.Controls.Add(this.dgvGenreStats);
            this.tabGenreStats.Location = new System.Drawing.Point(0, 40);
            this.tabGenreStats.Name = "tabGenreStats";
            this.tabGenreStats.Size = new System.Drawing.Size(1167, 588);
            this.tabGenreStats.TabIndex = 0;
            this.tabGenreStats.Text = "📈 Thống kê theo thể loại";
            // 
            // dgvGenreStats
            // 
            this.dgvGenreStats.AllowUserToAddRows = false;
            this.dgvGenreStats.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvGenreStats.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGenreStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGenreStats.BackgroundColor = System.Drawing.Color.White;
            this.dgvGenreStats.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGenreStats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGenreStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenreStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGenreStats.EnableHeadersVisualStyles = false;
            this.dgvGenreStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvGenreStats.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvGenreStats.Location = new System.Drawing.Point(0, 0);
            this.dgvGenreStats.Name = "dgvGenreStats";
            this.dgvGenreStats.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGenreStats.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGenreStats.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvGenreStats.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGenreStats.RowTemplate.Height = 24;
            this.dgvGenreStats.SelectedIndex = -1;
            this.dgvGenreStats.Size = new System.Drawing.Size(1167, 588);
            this.dgvGenreStats.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvGenreStats.TabIndex = 0;
            // 
            // tabTopSongs
            // 
            this.tabTopSongs.BackColor = System.Drawing.Color.White;
            this.tabTopSongs.Controls.Add(this.dgvTopSongs);
            this.tabTopSongs.Location = new System.Drawing.Point(0, 40);
            this.tabTopSongs.Name = "tabTopSongs";
            this.tabTopSongs.Size = new System.Drawing.Size(200, 60);
            this.tabTopSongs.TabIndex = 1;
            this.tabTopSongs.Text = "🔥 Top bài hát";
            // 
            // dgvTopSongs
            // 
            this.dgvTopSongs.AllowUserToAddRows = false;
            this.dgvTopSongs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvTopSongs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTopSongs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopSongs.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopSongs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTopSongs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTopSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopSongs.EnableHeadersVisualStyles = false;
            this.dgvTopSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvTopSongs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvTopSongs.Location = new System.Drawing.Point(0, 0);
            this.dgvTopSongs.Name = "dgvTopSongs";
            this.dgvTopSongs.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTopSongs.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTopSongs.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvTopSongs.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTopSongs.RowTemplate.Height = 24;
            this.dgvTopSongs.SelectedIndex = -1;
            this.dgvTopSongs.Size = new System.Drawing.Size(200, 60);
            this.dgvTopSongs.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvTopSongs.TabIndex = 0;
            // 
            // tabFavorites
            // 
            this.tabFavorites.BackColor = System.Drawing.Color.White;
            this.tabFavorites.Controls.Add(this.dgvFavorites);
            this.tabFavorites.Location = new System.Drawing.Point(0, 40);
            this.tabFavorites.Name = "tabFavorites";
            this.tabFavorites.Size = new System.Drawing.Size(200, 60);
            this.tabFavorites.TabIndex = 2;
            this.tabFavorites.Text = "❤️ Yêu thích";
            // 
            // dgvFavorites
            // 
            this.dgvFavorites.AllowUserToAddRows = false;
            this.dgvFavorites.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvFavorites.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvFavorites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFavorites.BackgroundColor = System.Drawing.Color.White;
            this.dgvFavorites.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFavorites.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvFavorites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFavorites.EnableHeadersVisualStyles = false;
            this.dgvFavorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvFavorites.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvFavorites.Location = new System.Drawing.Point(0, 0);
            this.dgvFavorites.Name = "dgvFavorites";
            this.dgvFavorites.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFavorites.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvFavorites.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvFavorites.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvFavorites.RowTemplate.Height = 24;
            this.dgvFavorites.SelectedIndex = -1;
            this.dgvFavorites.Size = new System.Drawing.Size(200, 60);
            this.dgvFavorites.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvFavorites.TabIndex = 0;
            // 
            // StatisticsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1167, 783);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnlTop);
            this.Name = "StatisticsForm";
            this.Text = "Thống kê & Báo cáo";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 1150, 755);
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabGenreStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenreStats)).EndInit();
            this.tabTopSongs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSongs)).EndInit();
            this.tabFavorites.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavorites)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel pnlTop;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UILabel lblTotalSongs;
        private Sunny.UI.UILabel lblFavoriteCount;
        private Sunny.UI.UILabel lblPlaylistCount;
        private Sunny.UI.UISymbolButton btnRefresh;
        private Sunny.UI.UITabControl tabControl;
        private System.Windows.Forms.TabPage tabGenreStats;
        private Sunny.UI.UIDataGridView dgvGenreStats;
        private System.Windows.Forms.TabPage tabTopSongs;
        private Sunny.UI.UIDataGridView dgvTopSongs;
        private System.Windows.Forms.TabPage tabFavorites;
        private Sunny.UI.UIDataGridView dgvFavorites;
    }
}

