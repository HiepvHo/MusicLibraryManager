namespace MusicLibraryManager.GUI
{
    partial class HistoryForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new Sunny.UI.UIPanel();
            this.btnMostPlayed = new Sunny.UI.UISymbolButton();
            this.btnClearOld = new Sunny.UI.UISymbolButton();
            this.btnClearAll = new Sunny.UI.UISymbolButton();
            this.btnFilter = new Sunny.UI.UISymbolButton();
            this.btnRefresh = new Sunny.UI.UISymbolButton();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.lblTitle = new Sunny.UI.UILabel();
            this.pnlStats = new Sunny.UI.UIPanel();
            this.lblLast30Days = new Sunny.UI.UILabel();
            this.lblLast7Days = new Sunny.UI.UILabel();
            this.lblUniqueSongs = new Sunny.UI.UILabel();
            this.lblTotalPlays = new Sunny.UI.UILabel();
            this.pnlBottom = new Sunny.UI.UIPanel();
            this.lblTotalRecords = new Sunny.UI.UILabel();
            this.dgvHistory = new Sunny.UI.UIDataGridView();
            this.contextMenuHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuPlaySong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuDeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTop.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.contextMenuHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnMostPlayed);
            this.pnlTop.Controls.Add(this.btnClearOld);
            this.pnlTop.Controls.Add(this.btnClearAll);
            this.pnlTop.Controls.Add(this.btnFilter);
            this.pnlTop.Controls.Add(this.btnRefresh);
            this.pnlTop.Controls.Add(this.dtpTo);
            this.pnlTop.Controls.Add(this.dtpFrom);
            this.pnlTop.Controls.Add(this.uiLabel2);
            this.pnlTop.Controls.Add(this.uiLabel1);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlTop.Location = new System.Drawing.Point(0, 35);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1200, 120);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.Text = null;
            this.pnlTop.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMostPlayed
            // 
            this.btnMostPlayed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMostPlayed.Location = new System.Drawing.Point(910, 65);
            this.btnMostPlayed.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMostPlayed.Name = "btnMostPlayed";
            this.btnMostPlayed.Size = new System.Drawing.Size(130, 40);
            this.btnMostPlayed.Symbol = 61459;
            this.btnMostPlayed.TabIndex = 9;
            this.btnMostPlayed.Text = "Top Songs";
            this.btnMostPlayed.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnMostPlayed.Click += new System.EventHandler(this.btnMostPlayed_Click);
            // 
            // btnClearOld
            // 
            this.btnClearOld.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClearOld.Location = new System.Drawing.Point(760, 65);
            this.btnClearOld.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClearOld.Name = "btnClearOld";
            this.btnClearOld.Size = new System.Drawing.Size(130, 40);
            this.btnClearOld.Symbol = 61584;
            this.btnClearOld.TabIndex = 8;
            this.btnClearOld.Text = "Xóa cũ";
            this.btnClearOld.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnClearOld.Click += new System.EventHandler(this.btnClearOld_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClearAll.Location = new System.Drawing.Point(610, 65);
            this.btnClearAll.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(130, 40);
            this.btnClearAll.Symbol = 61516;
            this.btnClearAll.TabIndex = 7;
            this.btnClearAll.Text = "Xóa tất cả";
            this.btnClearAll.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFilter.Location = new System.Drawing.Point(460, 65);
            this.btnFilter.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(130, 40);
            this.btnFilter.Symbol = 61616;
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(20, 65);
            this.btnRefresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(130, 40);
            this.btnRefresh.Symbol = 61473;
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(310, 72);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(130, 24);
            this.dtpTo.TabIndex = 4;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(170, 72);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(130, 24);
            this.dtpFrom.TabIndex = 3;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(306, 72);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(10, 23);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "-";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(165, 45);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(140, 23);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "Lọc theo ngày:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📜 Lịch sử phát nhạc";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlStats
            // 
            this.pnlStats.Controls.Add(this.lblLast30Days);
            this.pnlStats.Controls.Add(this.lblLast7Days);
            this.pnlStats.Controls.Add(this.lblUniqueSongs);
            this.pnlStats.Controls.Add(this.lblTotalPlays);
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlStats.Location = new System.Drawing.Point(0, 155);
            this.pnlStats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlStats.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(1200, 60);
            this.pnlStats.TabIndex = 1;
            this.pnlStats.Text = null;
            this.pnlStats.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLast30Days
            // 
            this.lblLast30Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblLast30Days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblLast30Days.Location = new System.Drawing.Point(760, 15);
            this.lblLast30Days.Name = "lblLast30Days";
            this.lblLast30Days.Size = new System.Drawing.Size(250, 30);
            this.lblLast30Days.TabIndex = 3;
            this.lblLast30Days.Text = "30 ngày gần đây: 0 lượt";
            this.lblLast30Days.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLast7Days
            // 
            this.lblLast7Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblLast7Days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblLast7Days.Location = new System.Drawing.Point(510, 15);
            this.lblLast7Days.Name = "lblLast7Days";
            this.lblLast7Days.Size = new System.Drawing.Size(240, 30);
            this.lblLast7Days.TabIndex = 2;
            this.lblLast7Days.Text = "7 ngày gần đây: 0 lượt";
            this.lblLast7Days.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUniqueSongs
            // 
            this.lblUniqueSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblUniqueSongs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblUniqueSongs.Location = new System.Drawing.Point(270, 15);
            this.lblUniqueSongs.Name = "lblUniqueSongs";
            this.lblUniqueSongs.Size = new System.Drawing.Size(230, 30);
            this.lblUniqueSongs.TabIndex = 1;
            this.lblUniqueSongs.Text = "Bài hát unique: 0";
            this.lblUniqueSongs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPlays
            // 
            this.lblTotalPlays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTotalPlays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTotalPlays.Location = new System.Drawing.Point(20, 15);
            this.lblTotalPlays.Name = "lblTotalPlays";
            this.lblTotalPlays.Size = new System.Drawing.Size(240, 30);
            this.lblTotalPlays.TabIndex = 0;
            this.lblTotalPlays.Text = "Tổng lượt phát: 0";
            this.lblTotalPlays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.lblTotalRecords);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlBottom.Location = new System.Drawing.Point(0, 660);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBottom.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1200, 40);
            this.pnlBottom.TabIndex = 2;
            this.pnlBottom.Text = null;
            this.pnlBottom.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTotalRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTotalRecords.Location = new System.Drawing.Point(0, 0);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTotalRecords.Size = new System.Drawing.Size(1200, 40);
            this.lblTotalRecords.TabIndex = 0;
            this.lblTotalRecords.Text = "Tổng số: 0 lượt phát";
            this.lblTotalRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvHistory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistory.ColumnHeadersHeight = 32;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.EnableHeadersVisualStyles = false;
            this.dgvHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvHistory.Location = new System.Drawing.Point(0, 215);
            this.dgvHistory.Name = "dgvHistory";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHistory.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvHistory.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHistory.RowTemplate.Height = 30;
            this.dgvHistory.SelectedIndex = -1;
            this.dgvHistory.Size = new System.Drawing.Size(1200, 445);
            this.dgvHistory.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvHistory.TabIndex = 3;
            this.dgvHistory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistory_CellDoubleClick);
            this.dgvHistory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvHistory_MouseDown);
            // 
            // contextMenuHistory
            // 
            this.contextMenuHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPlaySong,
            this.toolStripSeparator1,
            this.menuDeleteItem});
            this.contextMenuHistory.Name = "contextMenuHistory";
            this.contextMenuHistory.Size = new System.Drawing.Size(181, 76);
            // 
            // menuPlaySong
            // 
            this.menuPlaySong.Name = "menuPlaySong";
            this.menuPlaySong.Size = new System.Drawing.Size(180, 22);
            this.menuPlaySong.Text = "▶️ Phát bài hát này";
            this.menuPlaySong.Click += new System.EventHandler(this.menuPlaySong_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuDeleteItem
            // 
            this.menuDeleteItem.Name = "menuDeleteItem";
            this.menuDeleteItem.Size = new System.Drawing.Size(180, 22);
            this.menuDeleteItem.Text = "🗑️ Xóa khỏi lịch sử";
            this.menuDeleteItem.Click += new System.EventHandler(this.menuDeleteItem_Click);
            // 
            // HistoryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.pnlTop);
            this.Name = "HistoryForm";
            this.Text = "Lịch sử phát nhạc";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.pnlTop.ResumeLayout(false);
            this.pnlStats.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.contextMenuHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel pnlTop;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private Sunny.UI.UISymbolButton btnRefresh;
        private Sunny.UI.UISymbolButton btnFilter;
        private Sunny.UI.UISymbolButton btnClearAll;
        private Sunny.UI.UISymbolButton btnClearOld;
        private Sunny.UI.UISymbolButton btnMostPlayed;
        private Sunny.UI.UIPanel pnlStats;
        private Sunny.UI.UILabel lblTotalPlays;
        private Sunny.UI.UILabel lblUniqueSongs;
        private Sunny.UI.UILabel lblLast7Days;
        private Sunny.UI.UILabel lblLast30Days;
        private Sunny.UI.UIPanel pnlBottom;
        private Sunny.UI.UILabel lblTotalRecords;
        private Sunny.UI.UIDataGridView dgvHistory;
        private System.Windows.Forms.ContextMenuStrip contextMenuHistory;
        private System.Windows.Forms.ToolStripMenuItem menuPlaySong;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteItem;
    }
}

