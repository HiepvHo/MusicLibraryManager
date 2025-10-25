namespace MusicLibraryManager.GUI
{
    partial class PlaylistManagementForm
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pnlPlaylistLeft = new Sunny.UI.UIPanel();
            this.dgvPlaylists = new Sunny.UI.UIDataGridView();
            this.pnlPlaylistTop = new Sunny.UI.UIPanel();
            this.btnRefresh = new Sunny.UI.UISymbolButton();
            this.lblTotalPlaylists = new Sunny.UI.UILabel();
            this.lblTitle = new Sunny.UI.UILabel();
            this.pnlPlaylistRight = new Sunny.UI.UIPanel();
            this.txtDescription = new Sunny.UI.UITextBox();
            this.lblDescription = new Sunny.UI.UILabel();
            this.txtPlaylistName = new Sunny.UI.UITextBox();
            this.lblPlaylistName = new Sunny.UI.UILabel();
            this.btnDeletePlaylist = new Sunny.UI.UIButton();
            this.btnUpdatePlaylist = new Sunny.UI.UIButton();
            this.btnCreatePlaylist = new Sunny.UI.UIButton();
            this.pnlSongManagement = new Sunny.UI.UIPanel();
            this.splitSongs = new System.Windows.Forms.SplitContainer();
            this.pnlAllSongs = new Sunny.UI.UIPanel();
            this.dgvAllSongs = new Sunny.UI.UIDataGridView();
            this.pnlAllSongsTop = new Sunny.UI.UIPanel();
            this.txtSearchSong = new Sunny.UI.UITextBox();
            this.lblAllSongs = new Sunny.UI.UILabel();
            this.btnAddSongToPlaylist = new Sunny.UI.UISymbolButton();
            this.pnlPlaylistSongs = new Sunny.UI.UIPanel();
            this.dgvPlaylistSongs = new Sunny.UI.UIDataGridView();
            this.pnlPlaylistSongsTop = new Sunny.UI.UIPanel();
            this.lblTotalSongsInPlaylist = new Sunny.UI.UILabel();
            this.lblCurrentPlaylist = new Sunny.UI.UILabel();
            this.btnPlayPlaylist = new Sunny.UI.UISymbolButton();
            this.btnRemoveSongFromPlaylist = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.pnlPlaylistLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylists)).BeginInit();
            this.pnlPlaylistTop.SuspendLayout();
            this.pnlPlaylistRight.SuspendLayout();
            this.pnlSongManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitSongs)).BeginInit();
            this.splitSongs.Panel1.SuspendLayout();
            this.splitSongs.Panel2.SuspendLayout();
            this.splitSongs.SuspendLayout();
            this.pnlAllSongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllSongs)).BeginInit();
            this.pnlAllSongsTop.SuspendLayout();
            this.pnlPlaylistSongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylistSongs)).BeginInit();
            this.pnlPlaylistSongsTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer.Location = new System.Drawing.Point(0, 35);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.pnlPlaylistLeft);
            this.splitContainer.Panel1.Controls.Add(this.pnlPlaylistTop);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pnlPlaylistRight);
            this.splitContainer.Size = new System.Drawing.Size(1170, 300);
            this.splitContainer.SplitterDistance = 712;
            this.splitContainer.TabIndex = 0;
            // 
            // pnlPlaylistLeft
            // 
            this.pnlPlaylistLeft.Controls.Add(this.dgvPlaylists);
            this.pnlPlaylistLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlaylistLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlPlaylistLeft.Location = new System.Drawing.Point(0, 80);
            this.pnlPlaylistLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPlaylistLeft.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlPlaylistLeft.Name = "pnlPlaylistLeft";
            this.pnlPlaylistLeft.Padding = new System.Windows.Forms.Padding(10);
            this.pnlPlaylistLeft.Size = new System.Drawing.Size(712, 220);
            this.pnlPlaylistLeft.TabIndex = 1;
            this.pnlPlaylistLeft.Text = null;
            this.pnlPlaylistLeft.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPlaylists
            // 
            this.dgvPlaylists.AllowUserToAddRows = false;
            this.dgvPlaylists.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvPlaylists.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlaylists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlaylists.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlaylists.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlaylists.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlaylists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaylists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlaylists.EnableHeadersVisualStyles = false;
            this.dgvPlaylists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvPlaylists.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvPlaylists.Location = new System.Drawing.Point(10, 10);
            this.dgvPlaylists.MultiSelect = false;
            this.dgvPlaylists.Name = "dgvPlaylists";
            this.dgvPlaylists.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlaylists.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPlaylists.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvPlaylists.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPlaylists.RowTemplate.Height = 24;
            this.dgvPlaylists.SelectedIndex = -1;
            this.dgvPlaylists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlaylists.Size = new System.Drawing.Size(692, 200);
            this.dgvPlaylists.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvPlaylists.TabIndex = 0;
            this.dgvPlaylists.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlaylists_CellDoubleClick);
            this.dgvPlaylists.SelectionChanged += new System.EventHandler(this.dgvPlaylists_SelectionChanged);
            // 
            // pnlPlaylistTop
            // 
            this.pnlPlaylistTop.Controls.Add(this.btnRefresh);
            this.pnlPlaylistTop.Controls.Add(this.lblTotalPlaylists);
            this.pnlPlaylistTop.Controls.Add(this.lblTitle);
            this.pnlPlaylistTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPlaylistTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlPlaylistTop.Location = new System.Drawing.Point(0, 0);
            this.pnlPlaylistTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPlaylistTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlPlaylistTop.Name = "pnlPlaylistTop";
            this.pnlPlaylistTop.Size = new System.Drawing.Size(712, 80);
            this.pnlPlaylistTop.TabIndex = 0;
            this.pnlPlaylistTop.Text = null;
            this.pnlPlaylistTop.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRefresh.Location = new System.Drawing.Point(571, 30);
            this.btnRefresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 35);
            this.btnRefresh.Symbol = 61473;
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTotalPlaylists
            // 
            this.lblTotalPlaylists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotalPlaylists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTotalPlaylists.Location = new System.Drawing.Point(420, 35);
            this.lblTotalPlaylists.Name = "lblTotalPlaylists";
            this.lblTotalPlaylists.Size = new System.Drawing.Size(160, 25);
            this.lblTotalPlaylists.TabIndex = 1;
            this.lblTotalPlaylists.Text = "Tổng số: 0 playlist";
            this.lblTotalPlaylists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(350, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🎵 DANH SÁCH PLAYLIST";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlPlaylistRight
            // 
            this.pnlPlaylistRight.Controls.Add(this.txtDescription);
            this.pnlPlaylistRight.Controls.Add(this.lblDescription);
            this.pnlPlaylistRight.Controls.Add(this.txtPlaylistName);
            this.pnlPlaylistRight.Controls.Add(this.lblPlaylistName);
            this.pnlPlaylistRight.Controls.Add(this.btnDeletePlaylist);
            this.pnlPlaylistRight.Controls.Add(this.btnUpdatePlaylist);
            this.pnlPlaylistRight.Controls.Add(this.btnCreatePlaylist);
            this.pnlPlaylistRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlaylistRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlPlaylistRight.Location = new System.Drawing.Point(0, 0);
            this.pnlPlaylistRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPlaylistRight.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlPlaylistRight.Name = "pnlPlaylistRight";
            this.pnlPlaylistRight.Padding = new System.Windows.Forms.Padding(10);
            this.pnlPlaylistRight.Size = new System.Drawing.Size(454, 300);
            this.pnlPlaylistRight.TabIndex = 0;
            this.pnlPlaylistRight.Text = null;
            this.pnlPlaylistRight.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDescription.Location = new System.Drawing.Point(20, 115);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(5);
            this.txtDescription.ShowText = false;
            this.txtDescription.Size = new System.Drawing.Size(400, 80);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDescription.Watermark = "Mô tả playlist...";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblDescription.Location = new System.Drawing.Point(20, 85);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(200, 25);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Mô tả:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPlaylistName
            // 
            this.txtPlaylistName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlaylistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPlaylistName.Location = new System.Drawing.Point(20, 45);
            this.txtPlaylistName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPlaylistName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPlaylistName.Name = "txtPlaylistName";
            this.txtPlaylistName.Padding = new System.Windows.Forms.Padding(5);
            this.txtPlaylistName.ShowText = false;
            this.txtPlaylistName.Size = new System.Drawing.Size(400, 35);
            this.txtPlaylistName.TabIndex = 4;
            this.txtPlaylistName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPlaylistName.Watermark = "Tên playlist";
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPlaylistName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblPlaylistName.Location = new System.Drawing.Point(20, 15);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(200, 25);
            this.lblPlaylistName.TabIndex = 3;
            this.lblPlaylistName.Text = "Tên playlist: *";
            this.lblPlaylistName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeletePlaylist
            // 
            this.btnDeletePlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeletePlaylist.Location = new System.Drawing.Point(300, 215);
            this.btnDeletePlaylist.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDeletePlaylist.Name = "btnDeletePlaylist";
            this.btnDeletePlaylist.Size = new System.Drawing.Size(120, 45);
            this.btnDeletePlaylist.TabIndex = 2;
            this.btnDeletePlaylist.Text = "🗑️ Xóa";
            this.btnDeletePlaylist.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDeletePlaylist.Click += new System.EventHandler(this.btnDeletePlaylist_Click);
            // 
            // btnUpdatePlaylist
            // 
            this.btnUpdatePlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatePlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdatePlaylist.Location = new System.Drawing.Point(160, 215);
            this.btnUpdatePlaylist.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpdatePlaylist.Name = "btnUpdatePlaylist";
            this.btnUpdatePlaylist.Size = new System.Drawing.Size(120, 45);
            this.btnUpdatePlaylist.TabIndex = 1;
            this.btnUpdatePlaylist.Text = "✏️ Sửa";
            this.btnUpdatePlaylist.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnUpdatePlaylist.Click += new System.EventHandler(this.btnUpdatePlaylist_Click);
            // 
            // btnCreatePlaylist
            // 
            this.btnCreatePlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreatePlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCreatePlaylist.Location = new System.Drawing.Point(20, 215);
            this.btnCreatePlaylist.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCreatePlaylist.Name = "btnCreatePlaylist";
            this.btnCreatePlaylist.Size = new System.Drawing.Size(120, 45);
            this.btnCreatePlaylist.TabIndex = 0;
            this.btnCreatePlaylist.Text = "➕ Tạo mới";
            this.btnCreatePlaylist.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCreatePlaylist.Click += new System.EventHandler(this.btnCreatePlaylist_Click);
            // 
            // pnlSongManagement
            // 
            this.pnlSongManagement.Controls.Add(this.splitSongs);
            this.pnlSongManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSongManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlSongManagement.Location = new System.Drawing.Point(0, 335);
            this.pnlSongManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSongManagement.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlSongManagement.Name = "pnlSongManagement";
            this.pnlSongManagement.Size = new System.Drawing.Size(1170, 447);
            this.pnlSongManagement.TabIndex = 1;
            this.pnlSongManagement.Text = null;
            this.pnlSongManagement.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitSongs
            // 
            this.splitSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitSongs.Location = new System.Drawing.Point(0, 0);
            this.splitSongs.Name = "splitSongs";
            // 
            // splitSongs.Panel1
            // 
            this.splitSongs.Panel1.Controls.Add(this.pnlAllSongs);
            // 
            // splitSongs.Panel2
            // 
            this.splitSongs.Panel2.Controls.Add(this.pnlPlaylistSongs);
            this.splitSongs.Size = new System.Drawing.Size(1170, 447);
            this.splitSongs.SplitterDistance = 585;
            this.splitSongs.TabIndex = 0;
            // 
            // pnlAllSongs
            // 
            this.pnlAllSongs.Controls.Add(this.dgvAllSongs);
            this.pnlAllSongs.Controls.Add(this.pnlAllSongsTop);
            this.pnlAllSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAllSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlAllSongs.Location = new System.Drawing.Point(0, 0);
            this.pnlAllSongs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAllSongs.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlAllSongs.Name = "pnlAllSongs";
            this.pnlAllSongs.Padding = new System.Windows.Forms.Padding(10);
            this.pnlAllSongs.Size = new System.Drawing.Size(585, 447);
            this.pnlAllSongs.TabIndex = 0;
            this.pnlAllSongs.Text = null;
            this.pnlAllSongs.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvAllSongs
            // 
            this.dgvAllSongs.AllowUserToAddRows = false;
            this.dgvAllSongs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvAllSongs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAllSongs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllSongs.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllSongs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllSongs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAllSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllSongs.EnableHeadersVisualStyles = false;
            this.dgvAllSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dgvAllSongs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvAllSongs.Location = new System.Drawing.Point(10, 90);
            this.dgvAllSongs.MultiSelect = false;
            this.dgvAllSongs.Name = "dgvAllSongs";
            this.dgvAllSongs.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllSongs.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAllSongs.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvAllSongs.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAllSongs.RowTemplate.Height = 24;
            this.dgvAllSongs.SelectedIndex = -1;
            this.dgvAllSongs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllSongs.Size = new System.Drawing.Size(565, 347);
            this.dgvAllSongs.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvAllSongs.TabIndex = 1;
            // 
            // pnlAllSongsTop
            // 
            this.pnlAllSongsTop.Controls.Add(this.txtSearchSong);
            this.pnlAllSongsTop.Controls.Add(this.lblAllSongs);
            this.pnlAllSongsTop.Controls.Add(this.btnAddSongToPlaylist);
            this.pnlAllSongsTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAllSongsTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlAllSongsTop.Location = new System.Drawing.Point(10, 10);
            this.pnlAllSongsTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAllSongsTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlAllSongsTop.Name = "pnlAllSongsTop";
            this.pnlAllSongsTop.Size = new System.Drawing.Size(565, 80);
            this.pnlAllSongsTop.TabIndex = 0;
            this.pnlAllSongsTop.Text = null;
            this.pnlAllSongsTop.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearchSong
            // 
            this.txtSearchSong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearchSong.Location = new System.Drawing.Point(10, 40);
            this.txtSearchSong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchSong.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSearchSong.Name = "txtSearchSong";
            this.txtSearchSong.Padding = new System.Windows.Forms.Padding(5);
            this.txtSearchSong.ShowText = false;
            this.txtSearchSong.Size = new System.Drawing.Size(370, 30);
            this.txtSearchSong.TabIndex = 2;
            this.txtSearchSong.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSearchSong.Watermark = "Tìm kiếm bài hát...";
            this.txtSearchSong.TextChanged += new System.EventHandler(this.txtSearchSong_TextChanged);
            // 
            // lblAllSongs
            // 
            this.lblAllSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblAllSongs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblAllSongs.Location = new System.Drawing.Point(10, 5);
            this.lblAllSongs.Name = "lblAllSongs";
            this.lblAllSongs.Size = new System.Drawing.Size(300, 30);
            this.lblAllSongs.TabIndex = 1;
            this.lblAllSongs.Text = "TẤT CẢ BÀI HÁT";
            this.lblAllSongs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddSongToPlaylist
            // 
            this.btnAddSongToPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSongToPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddSongToPlaylist.Location = new System.Drawing.Point(400, 35);
            this.btnAddSongToPlaylist.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddSongToPlaylist.Name = "btnAddSongToPlaylist";
            this.btnAddSongToPlaylist.Size = new System.Drawing.Size(140, 40);
            this.btnAddSongToPlaylist.Symbol = 61525;
            this.btnAddSongToPlaylist.TabIndex = 0;
            this.btnAddSongToPlaylist.Text = "Thêm vào ▶";
            this.btnAddSongToPlaylist.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddSongToPlaylist.Click += new System.EventHandler(this.btnAddSongToPlaylist_Click);
            // 
            // pnlPlaylistSongs
            // 
            this.pnlPlaylistSongs.Controls.Add(this.dgvPlaylistSongs);
            this.pnlPlaylistSongs.Controls.Add(this.pnlPlaylistSongsTop);
            this.pnlPlaylistSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlaylistSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlPlaylistSongs.Location = new System.Drawing.Point(0, 0);
            this.pnlPlaylistSongs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPlaylistSongs.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlPlaylistSongs.Name = "pnlPlaylistSongs";
            this.pnlPlaylistSongs.Padding = new System.Windows.Forms.Padding(10);
            this.pnlPlaylistSongs.Size = new System.Drawing.Size(581, 447);
            this.pnlPlaylistSongs.TabIndex = 0;
            this.pnlPlaylistSongs.Text = null;
            this.pnlPlaylistSongs.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPlaylistSongs
            // 
            this.dgvPlaylistSongs.AllowUserToAddRows = false;
            this.dgvPlaylistSongs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvPlaylistSongs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPlaylistSongs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlaylistSongs.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlaylistSongs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlaylistSongs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPlaylistSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaylistSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlaylistSongs.EnableHeadersVisualStyles = false;
            this.dgvPlaylistSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dgvPlaylistSongs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvPlaylistSongs.Location = new System.Drawing.Point(10, 90);
            this.dgvPlaylistSongs.MultiSelect = false;
            this.dgvPlaylistSongs.Name = "dgvPlaylistSongs";
            this.dgvPlaylistSongs.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlaylistSongs.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPlaylistSongs.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvPlaylistSongs.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPlaylistSongs.RowTemplate.Height = 24;
            this.dgvPlaylistSongs.SelectedIndex = -1;
            this.dgvPlaylistSongs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlaylistSongs.Size = new System.Drawing.Size(561, 347);
            this.dgvPlaylistSongs.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvPlaylistSongs.TabIndex = 1;
            this.dgvPlaylistSongs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlaylistSongs_CellDoubleClick);
            // 
            // pnlPlaylistSongsTop
            // 
            this.pnlPlaylistSongsTop.Controls.Add(this.lblTotalSongsInPlaylist);
            this.pnlPlaylistSongsTop.Controls.Add(this.lblCurrentPlaylist);
            this.pnlPlaylistSongsTop.Controls.Add(this.btnPlayPlaylist);
            this.pnlPlaylistSongsTop.Controls.Add(this.btnRemoveSongFromPlaylist);
            this.pnlPlaylistSongsTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPlaylistSongsTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlPlaylistSongsTop.Location = new System.Drawing.Point(10, 10);
            this.pnlPlaylistSongsTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPlaylistSongsTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlPlaylistSongsTop.Name = "pnlPlaylistSongsTop";
            this.pnlPlaylistSongsTop.Size = new System.Drawing.Size(561, 80);
            this.pnlPlaylistSongsTop.TabIndex = 0;
            this.pnlPlaylistSongsTop.Text = null;
            this.pnlPlaylistSongsTop.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalSongsInPlaylist
            // 
            this.lblTotalSongsInPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTotalSongsInPlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTotalSongsInPlaylist.Location = new System.Drawing.Point(11, 50);
            this.lblTotalSongsInPlaylist.Name = "lblTotalSongsInPlaylist";
            this.lblTotalSongsInPlaylist.Size = new System.Drawing.Size(261, 25);
            this.lblTotalSongsInPlaylist.TabIndex = 2;
            this.lblTotalSongsInPlaylist.Text = "Tổng số: 0 bài hát";
            this.lblTotalSongsInPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentPlaylist
            // 
            this.lblCurrentPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblCurrentPlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblCurrentPlaylist.Location = new System.Drawing.Point(10, 12);
            this.lblCurrentPlaylist.Name = "lblCurrentPlaylist";
            this.lblCurrentPlaylist.Size = new System.Drawing.Size(400, 25);
            this.lblCurrentPlaylist.TabIndex = 1;
            this.lblCurrentPlaylist.Text = "BÀI HÁT TRONG PLAYLIST";
            this.lblCurrentPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPlayPlaylist
            // 
            this.btnPlayPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPlayPlaylist.Location = new System.Drawing.Point(281, 34);
            this.btnPlayPlaylist.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPlayPlaylist.Name = "btnPlayPlaylist";
            this.btnPlayPlaylist.Size = new System.Drawing.Size(133, 40);
            this.btnPlayPlaylist.Symbol = 61515;
            this.btnPlayPlaylist.TabIndex = 0;
            this.btnPlayPlaylist.Text = "Phát Playlist";
            this.btnPlayPlaylist.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPlayPlaylist.Click += new System.EventHandler(this.btnPlayPlaylist_Click);
            // 
            // btnRemoveSongFromPlaylist
            // 
            this.btnRemoveSongFromPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveSongFromPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRemoveSongFromPlaylist.Location = new System.Drawing.Point(420, 35);
            this.btnRemoveSongFromPlaylist.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRemoveSongFromPlaylist.Name = "btnRemoveSongFromPlaylist";
            this.btnRemoveSongFromPlaylist.Size = new System.Drawing.Size(120, 40);
            this.btnRemoveSongFromPlaylist.Symbol = 61526;
            this.btnRemoveSongFromPlaylist.TabIndex = 0;
            this.btnRemoveSongFromPlaylist.Text = "Xóa khỏi";
            this.btnRemoveSongFromPlaylist.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRemoveSongFromPlaylist.Click += new System.EventHandler(this.btnRemoveSongFromPlaylist_Click);
            // 
            // PlaylistManagementForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1170, 782);
            this.Controls.Add(this.pnlSongManagement);
            this.Controls.Add(this.splitContainer);
            this.Name = "PlaylistManagementForm";
            this.Text = "Quản lý Playlist";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 1150, 755);
            this.Load += new System.EventHandler(this.PlaylistManagementForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.pnlPlaylistLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylists)).EndInit();
            this.pnlPlaylistTop.ResumeLayout(false);
            this.pnlPlaylistRight.ResumeLayout(false);
            this.pnlSongManagement.ResumeLayout(false);
            this.splitSongs.Panel1.ResumeLayout(false);
            this.splitSongs.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitSongs)).EndInit();
            this.splitSongs.ResumeLayout(false);
            this.pnlAllSongs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllSongs)).EndInit();
            this.pnlAllSongsTop.ResumeLayout(false);
            this.pnlPlaylistSongs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylistSongs)).EndInit();
            this.pnlPlaylistSongsTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private Sunny.UI.UIPanel pnlPlaylistLeft;
        private Sunny.UI.UIDataGridView dgvPlaylists;
        private Sunny.UI.UIPanel pnlPlaylistTop;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UIPanel pnlPlaylistRight;
        private Sunny.UI.UIButton btnCreatePlaylist;
        private Sunny.UI.UIButton btnUpdatePlaylist;
        private Sunny.UI.UIButton btnDeletePlaylist;
        private Sunny.UI.UILabel lblPlaylistName;
        private Sunny.UI.UITextBox txtPlaylistName;
        private Sunny.UI.UILabel lblDescription;
        private Sunny.UI.UITextBox txtDescription;
        private Sunny.UI.UILabel lblTotalPlaylists;
        private Sunny.UI.UISymbolButton btnRefresh;
        private Sunny.UI.UIPanel pnlSongManagement;
        private System.Windows.Forms.SplitContainer splitSongs;
        private Sunny.UI.UIPanel pnlAllSongs;
        private Sunny.UI.UIDataGridView dgvAllSongs;
        private Sunny.UI.UIPanel pnlAllSongsTop;
        private Sunny.UI.UILabel lblAllSongs;
        private Sunny.UI.UISymbolButton btnAddSongToPlaylist;
        private Sunny.UI.UIPanel pnlPlaylistSongs;
        private Sunny.UI.UIDataGridView dgvPlaylistSongs;
        private Sunny.UI.UIPanel pnlPlaylistSongsTop;
        private Sunny.UI.UILabel lblCurrentPlaylist;
        private Sunny.UI.UISymbolButton btnRemoveSongFromPlaylist;
        private Sunny.UI.UITextBox txtSearchSong;
        private Sunny.UI.UILabel lblTotalSongsInPlaylist;
        private Sunny.UI.UISymbolButton btnPlayPlaylist;
    }
}

