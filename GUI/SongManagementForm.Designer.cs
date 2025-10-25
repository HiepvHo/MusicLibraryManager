namespace MusicLibraryManager.GUI
{
    partial class SongManagementForm
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
            this.pnlTop = new Sunny.UI.UIPanel();
            this.btnRefresh = new Sunny.UI.UISymbolButton();
            this.lblTotalSongs = new Sunny.UI.UILabel();
            this.txtSearch = new Sunny.UI.UITextBox();
            this.lblTitle = new Sunny.UI.UILabel();
            this.pnlLeft = new Sunny.UI.UIPanel();
            this.dgvSongs = new Sunny.UI.UIDataGridView();
            this.pnlRight = new Sunny.UI.UIPanel();
            this.btnToggleFavorite = new Sunny.UI.UIButton();
            this.txtYear = new Sunny.UI.UITextBox();
            this.lblYear = new Sunny.UI.UILabel();
            this.cboGenre = new Sunny.UI.UIComboBox();
            this.lblGenre = new Sunny.UI.UILabel();
            this.cboArtist = new Sunny.UI.UIComboBox();
            this.lblArtist = new Sunny.UI.UILabel();
            this.btnBrowse = new Sunny.UI.UISymbolButton();
            this.txtFilePath = new Sunny.UI.UITextBox();
            this.lblFilePath = new Sunny.UI.UILabel();
            this.txtTitle = new Sunny.UI.UITextBox();
            this.lblSongTitle = new Sunny.UI.UILabel();
            this.btnDelete = new Sunny.UI.UIButton();
            this.btnUpdate = new Sunny.UI.UIButton();
            this.btnAdd = new Sunny.UI.UIButton();
            this.lblFormTitle = new Sunny.UI.UILabel();
            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnRefresh);
            this.pnlTop.Controls.Add(this.lblTotalSongs);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlTop.Location = new System.Drawing.Point(0, 35);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1182, 80);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.Text = null;
            this.pnlTop.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRefresh.Location = new System.Drawing.Point(1020, 30);
            this.btnRefresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 35);
            this.btnRefresh.Symbol = 61473;
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTotalSongs
            // 
            this.lblTotalSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotalSongs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTotalSongs.Location = new System.Drawing.Point(870, 35);
            this.lblTotalSongs.Name = "lblTotalSongs";
            this.lblTotalSongs.Size = new System.Drawing.Size(160, 25);
            this.lblTotalSongs.TabIndex = 2;
            this.lblTotalSongs.Text = "Tổng số: 0 bài hát";
            this.lblTotalSongs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtSearch.Location = new System.Drawing.Point(430, 30);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(5);
            this.txtSearch.ShowText = false;
            this.txtSearch.Size = new System.Drawing.Size(420, 35);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSearch.Watermark = "Tìm kiếm bài hát, ca sĩ...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🎧 QUẢN LÝ BÀI HÁT";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.dgvSongs);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlLeft.Location = new System.Drawing.Point(0, 115);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLeft.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(10);
            this.pnlLeft.Size = new System.Drawing.Size(782, 720);
            this.pnlLeft.TabIndex = 1;
            this.pnlLeft.Text = null;
            this.pnlLeft.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSongs
            // 
            this.dgvSongs.AllowUserToAddRows = false;
            this.dgvSongs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvSongs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSongs.BackgroundColor = System.Drawing.Color.White;
            this.dgvSongs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSongs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSongs.EnableHeadersVisualStyles = false;
            this.dgvSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvSongs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvSongs.Location = new System.Drawing.Point(10, 10);
            this.dgvSongs.MultiSelect = false;
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSongs.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSongs.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvSongs.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSongs.RowTemplate.Height = 24;
            this.dgvSongs.SelectedIndex = -1;
            this.dgvSongs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSongs.Size = new System.Drawing.Size(762, 700);
            this.dgvSongs.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvSongs.TabIndex = 0;
            this.dgvSongs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSongs_CellContentClick);
            this.dgvSongs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSongs_CellDoubleClick);
            this.dgvSongs.SelectionChanged += new System.EventHandler(this.dgvSongs_SelectionChanged);
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.btnToggleFavorite);
            this.pnlRight.Controls.Add(this.txtYear);
            this.pnlRight.Controls.Add(this.lblYear);
            this.pnlRight.Controls.Add(this.cboGenre);
            this.pnlRight.Controls.Add(this.lblGenre);
            this.pnlRight.Controls.Add(this.cboArtist);
            this.pnlRight.Controls.Add(this.lblArtist);
            this.pnlRight.Controls.Add(this.btnBrowse);
            this.pnlRight.Controls.Add(this.txtFilePath);
            this.pnlRight.Controls.Add(this.lblFilePath);
            this.pnlRight.Controls.Add(this.txtTitle);
            this.pnlRight.Controls.Add(this.lblSongTitle);
            this.pnlRight.Controls.Add(this.btnDelete);
            this.pnlRight.Controls.Add(this.btnUpdate);
            this.pnlRight.Controls.Add(this.btnAdd);
            this.pnlRight.Controls.Add(this.lblFormTitle);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlRight.Location = new System.Drawing.Point(782, 115);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlRight.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(10);
            this.pnlRight.Size = new System.Drawing.Size(400, 720);
            this.pnlRight.TabIndex = 2;
            this.pnlRight.Text = null;
            this.pnlRight.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnToggleFavorite
            // 
            this.btnToggleFavorite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleFavorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnToggleFavorite.Location = new System.Drawing.Point(270, 446);
            this.btnToggleFavorite.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnToggleFavorite.Name = "btnToggleFavorite";
            this.btnToggleFavorite.Size = new System.Drawing.Size(110, 40);
            this.btnToggleFavorite.TabIndex = 17;
            this.btnToggleFavorite.Text = "❤️ Yêu thích";
            this.btnToggleFavorite.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnToggleFavorite.Click += new System.EventHandler(this.btnToggleFavorite_Click);
            // 
            // txtYear
            // 
            this.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtYear.Location = new System.Drawing.Point(20, 344);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtYear.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtYear.Name = "txtYear";
            this.txtYear.Padding = new System.Windows.Forms.Padding(5);
            this.txtYear.ShowText = false;
            this.txtYear.Size = new System.Drawing.Size(360, 35);
            this.txtYear.TabIndex = 14;
            this.txtYear.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtYear.Watermark = "VD: 2024";
            // 
            // lblYear
            // 
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblYear.Location = new System.Drawing.Point(20, 314);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(200, 25);
            this.lblYear.TabIndex = 13;
            this.lblYear.Text = "Năm phát hành:";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboGenre
            // 
            this.cboGenre.DataSource = null;
            this.cboGenre.FillColor = System.Drawing.Color.White;
            this.cboGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboGenre.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboGenre.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboGenre.Location = new System.Drawing.Point(20, 274);
            this.cboGenre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboGenre.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboGenre.Size = new System.Drawing.Size(360, 35);
            this.cboGenre.SymbolSize = 24;
            this.cboGenre.TabIndex = 12;
            this.cboGenre.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboGenre.Watermark = "Chọn thể loại";
            // 
            // lblGenre
            // 
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblGenre.Location = new System.Drawing.Point(20, 244);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(200, 25);
            this.lblGenre.TabIndex = 11;
            this.lblGenre.Text = "Thể loại:";
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboArtist
            // 
            this.cboArtist.DataSource = null;
            this.cboArtist.FillColor = System.Drawing.Color.White;
            this.cboArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboArtist.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboArtist.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboArtist.Location = new System.Drawing.Point(20, 204);
            this.cboArtist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboArtist.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboArtist.Name = "cboArtist";
            this.cboArtist.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboArtist.Size = new System.Drawing.Size(360, 35);
            this.cboArtist.SymbolSize = 24;
            this.cboArtist.TabIndex = 10;
            this.cboArtist.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboArtist.Watermark = "Chọn ca sĩ";
            // 
            // lblArtist
            // 
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblArtist.Location = new System.Drawing.Point(20, 174);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(200, 25);
            this.lblArtist.TabIndex = 9;
            this.lblArtist.Text = "Ca sĩ:";
            this.lblArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBrowse.Location = new System.Drawing.Point(340, 139);
            this.btnBrowse.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(40, 30);
            this.btnBrowse.Symbol = 61563;
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtFilePath.Location = new System.Drawing.Point(20, 134);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilePath.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Padding = new System.Windows.Forms.Padding(5);
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.ShowText = false;
            this.txtFilePath.Size = new System.Drawing.Size(310, 35);
            this.txtFilePath.TabIndex = 7;
            this.txtFilePath.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtFilePath.Watermark = "Chọn file nhạc...";
            // 
            // lblFilePath
            // 
            this.lblFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblFilePath.Location = new System.Drawing.Point(20, 104);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(200, 25);
            this.lblFilePath.TabIndex = 6;
            this.lblFilePath.Text = "File nhạc:";
            this.lblFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTitle
            // 
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTitle.Location = new System.Drawing.Point(20, 69);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Padding = new System.Windows.Forms.Padding(5);
            this.txtTitle.ShowText = false;
            this.txtTitle.Size = new System.Drawing.Size(360, 35);
            this.txtTitle.TabIndex = 5;
            this.txtTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTitle.Watermark = "Nhập tên bài hát";
            // 
            // lblSongTitle
            // 
            this.lblSongTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSongTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblSongTitle.Location = new System.Drawing.Point(20, 39);
            this.lblSongTitle.Name = "lblSongTitle";
            this.lblSongTitle.Size = new System.Drawing.Size(200, 25);
            this.lblSongTitle.TabIndex = 4;
            this.lblSongTitle.Text = "Tên bài hát: *";
            this.lblSongTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSongTitle.Click += new System.EventHandler(this.lblSongTitle_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.Location = new System.Drawing.Point(270, 394);
            this.btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 45);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "🗑️ Xóa";
            this.btnDelete.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdate.Location = new System.Drawing.Point(145, 394);
            this.btnUpdate.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 45);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "✏️ Sửa";
            this.btnUpdate.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.Location = new System.Drawing.Point(20, 394);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 45);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "➕ Thêm";
            this.btnAdd.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblFormTitle.Location = new System.Drawing.Point(10, 10);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(380, 35);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "THÔNG TIN BÀI HÁT";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SongManagementForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1182, 835);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlTop);
            this.Name = "SongManagementForm";
            this.Text = "Quản lý bài hát";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 1150, 755);
            this.Load += new System.EventHandler(this.SongManagementForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel pnlTop;
        private Sunny.UI.UIPanel pnlLeft;
        private Sunny.UI.UIPanel pnlRight;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UITextBox txtSearch;
        private Sunny.UI.UILabel lblTotalSongs;
        private Sunny.UI.UIDataGridView dgvSongs;
        private Sunny.UI.UILabel lblFormTitle;
        private Sunny.UI.UIButton btnAdd;
        private Sunny.UI.UIButton btnUpdate;
        private Sunny.UI.UIButton btnDelete;
        private Sunny.UI.UILabel lblSongTitle;
        private Sunny.UI.UITextBox txtTitle;
        private Sunny.UI.UILabel lblFilePath;
        private Sunny.UI.UITextBox txtFilePath;
        private Sunny.UI.UISymbolButton btnBrowse;
        private Sunny.UI.UILabel lblArtist;
        private Sunny.UI.UIComboBox cboArtist;
        private Sunny.UI.UILabel lblGenre;
        private Sunny.UI.UIComboBox cboGenre;
        private Sunny.UI.UILabel lblYear;
        private Sunny.UI.UITextBox txtYear;
        private Sunny.UI.UIButton btnToggleFavorite;
        private Sunny.UI.UISymbolButton btnRefresh;
    }
}

