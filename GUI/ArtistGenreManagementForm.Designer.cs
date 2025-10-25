namespace MusicLibraryManager.GUI
{
    partial class ArtistGenreManagementForm
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
            this.tabControl = new Sunny.UI.UITabControl();
            this.tabArtists = new System.Windows.Forms.TabPage();
            this.pnlArtistRight = new Sunny.UI.UIPanel();
            this.txtBiography = new Sunny.UI.UITextBox();
            this.lblBiography = new Sunny.UI.UILabel();
            this.txtCountry = new Sunny.UI.UITextBox();
            this.lblCountry = new Sunny.UI.UILabel();
            this.txtArtistName = new Sunny.UI.UITextBox();
            this.lblArtistName = new Sunny.UI.UILabel();
            this.btnDeleteArtist = new Sunny.UI.UIButton();
            this.btnUpdateArtist = new Sunny.UI.UIButton();
            this.btnAddArtist = new Sunny.UI.UIButton();
            this.lblArtistFormTitle = new Sunny.UI.UILabel();
            this.pnlArtistLeft = new Sunny.UI.UIPanel();
            this.dgvArtists = new Sunny.UI.UIDataGridView();
            this.pnlArtistTop = new Sunny.UI.UIPanel();
            this.btnRefreshArtist = new Sunny.UI.UISymbolButton();
            this.lblTotalArtists = new Sunny.UI.UILabel();
            this.txtSearchArtist = new Sunny.UI.UITextBox();
            this.lblArtistTitle = new Sunny.UI.UILabel();
            this.tabGenres = new System.Windows.Forms.TabPage();
            this.pnlGenreRight = new Sunny.UI.UIPanel();
            this.txtGenreDesc = new Sunny.UI.UITextBox();
            this.lblGenreDesc = new Sunny.UI.UILabel();
            this.txtGenreName = new Sunny.UI.UITextBox();
            this.lblGenreName = new Sunny.UI.UILabel();
            this.btnDeleteGenre = new Sunny.UI.UIButton();
            this.btnUpdateGenre = new Sunny.UI.UIButton();
            this.btnAddGenre = new Sunny.UI.UIButton();
            this.lblGenreFormTitle = new Sunny.UI.UILabel();
            this.pnlGenreLeft = new Sunny.UI.UIPanel();
            this.dgvGenres = new Sunny.UI.UIDataGridView();
            this.pnlGenreTop = new Sunny.UI.UIPanel();
            this.btnRefreshGenre = new Sunny.UI.UISymbolButton();
            this.lblTotalGenres = new Sunny.UI.UILabel();
            this.lblGenreTitle = new Sunny.UI.UILabel();
            this.tabControl.SuspendLayout();
            this.tabArtists.SuspendLayout();
            this.pnlArtistRight.SuspendLayout();
            this.pnlArtistLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtists)).BeginInit();
            this.pnlArtistTop.SuspendLayout();
            this.tabGenres.SuspendLayout();
            this.pnlGenreRight.SuspendLayout();
            this.pnlGenreLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).BeginInit();
            this.pnlGenreTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabArtists);
            this.tabControl.Controls.Add(this.tabGenres);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl.ItemSize = new System.Drawing.Size(200, 40);
            this.tabControl.Location = new System.Drawing.Point(0, 35);
            this.tabControl.MainPage = "";
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1150, 720);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            this.tabControl.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // tabArtists
            // 
            this.tabArtists.BackColor = System.Drawing.Color.White;
            this.tabArtists.Controls.Add(this.pnlArtistRight);
            this.tabArtists.Controls.Add(this.pnlArtistLeft);
            this.tabArtists.Controls.Add(this.pnlArtistTop);
            this.tabArtists.Location = new System.Drawing.Point(0, 40);
            this.tabArtists.Name = "tabArtists";
            this.tabArtists.Size = new System.Drawing.Size(1150, 680);
            this.tabArtists.TabIndex = 0;
            this.tabArtists.Text = "🎤 Quản lý Ca sĩ";
            // 
            // pnlArtistRight
            // 
            this.pnlArtistRight.Controls.Add(this.txtBiography);
            this.pnlArtistRight.Controls.Add(this.lblBiography);
            this.pnlArtistRight.Controls.Add(this.txtCountry);
            this.pnlArtistRight.Controls.Add(this.lblCountry);
            this.pnlArtistRight.Controls.Add(this.txtArtistName);
            this.pnlArtistRight.Controls.Add(this.lblArtistName);
            this.pnlArtistRight.Controls.Add(this.btnDeleteArtist);
            this.pnlArtistRight.Controls.Add(this.btnUpdateArtist);
            this.pnlArtistRight.Controls.Add(this.btnAddArtist);
            this.pnlArtistRight.Controls.Add(this.lblArtistFormTitle);
            this.pnlArtistRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlArtistRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlArtistRight.Location = new System.Drawing.Point(750, 80);
            this.pnlArtistRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlArtistRight.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlArtistRight.Name = "pnlArtistRight";
            this.pnlArtistRight.Padding = new System.Windows.Forms.Padding(10);
            this.pnlArtistRight.Size = new System.Drawing.Size(400, 600);
            this.pnlArtistRight.TabIndex = 2;
            this.pnlArtistRight.Text = null;
            this.pnlArtistRight.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBiography
            // 
            this.txtBiography.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBiography.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBiography.Location = new System.Drawing.Point(20, 222);
            this.txtBiography.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBiography.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtBiography.Multiline = true;
            this.txtBiography.Name = "txtBiography";
            this.txtBiography.Padding = new System.Windows.Forms.Padding(5);
            this.txtBiography.ShowText = false;
            this.txtBiography.Size = new System.Drawing.Size(360, 120);
            this.txtBiography.TabIndex = 9;
            this.txtBiography.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtBiography.Watermark = "Tiểu sử ca sĩ...";
            // 
            // lblBiography
            // 
            this.lblBiography.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBiography.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblBiography.Location = new System.Drawing.Point(20, 192);
            this.lblBiography.Name = "lblBiography";
            this.lblBiography.Size = new System.Drawing.Size(200, 25);
            this.lblBiography.TabIndex = 8;
            this.lblBiography.Text = "Tiểu sử:";
            this.lblBiography.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCountry
            // 
            this.txtCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCountry.Location = new System.Drawing.Point(20, 152);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCountry.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Padding = new System.Windows.Forms.Padding(5);
            this.txtCountry.ShowText = false;
            this.txtCountry.Size = new System.Drawing.Size(360, 35);
            this.txtCountry.TabIndex = 7;
            this.txtCountry.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtCountry.Watermark = "VD: Việt Nam";
            // 
            // lblCountry
            // 
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblCountry.Location = new System.Drawing.Point(20, 122);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(200, 25);
            this.lblCountry.TabIndex = 6;
            this.lblCountry.Text = "Quốc gia:";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtArtistName
            // 
            this.txtArtistName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtArtistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtArtistName.Location = new System.Drawing.Point(20, 82);
            this.txtArtistName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArtistName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Padding = new System.Windows.Forms.Padding(5);
            this.txtArtistName.ShowText = false;
            this.txtArtistName.Size = new System.Drawing.Size(360, 35);
            this.txtArtistName.TabIndex = 5;
            this.txtArtistName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtArtistName.Watermark = "Nhập tên ca sĩ";
            // 
            // lblArtistName
            // 
            this.lblArtistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblArtistName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblArtistName.Location = new System.Drawing.Point(20, 52);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(200, 25);
            this.lblArtistName.TabIndex = 4;
            this.lblArtistName.Text = "Tên ca sĩ: *";
            this.lblArtistName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeleteArtist
            // 
            this.btnDeleteArtist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteArtist.Location = new System.Drawing.Point(270, 361);
            this.btnDeleteArtist.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDeleteArtist.Name = "btnDeleteArtist";
            this.btnDeleteArtist.Size = new System.Drawing.Size(110, 45);
            this.btnDeleteArtist.TabIndex = 3;
            this.btnDeleteArtist.Text = "🗑️ Xóa";
            this.btnDeleteArtist.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDeleteArtist.Click += new System.EventHandler(this.btnDeleteArtist_Click);
            // 
            // btnUpdateArtist
            // 
            this.btnUpdateArtist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdateArtist.Location = new System.Drawing.Point(145, 361);
            this.btnUpdateArtist.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpdateArtist.Name = "btnUpdateArtist";
            this.btnUpdateArtist.Size = new System.Drawing.Size(110, 45);
            this.btnUpdateArtist.TabIndex = 2;
            this.btnUpdateArtist.Text = "✏️ Sửa";
            this.btnUpdateArtist.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnUpdateArtist.Click += new System.EventHandler(this.btnUpdateArtist_Click);
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddArtist.Location = new System.Drawing.Point(20, 361);
            this.btnAddArtist.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(110, 45);
            this.btnAddArtist.TabIndex = 1;
            this.btnAddArtist.Text = "➕ Thêm";
            this.btnAddArtist.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // lblArtistFormTitle
            // 
            this.lblArtistFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblArtistFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblArtistFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblArtistFormTitle.Location = new System.Drawing.Point(10, 10);
            this.lblArtistFormTitle.Name = "lblArtistFormTitle";
            this.lblArtistFormTitle.Size = new System.Drawing.Size(380, 35);
            this.lblArtistFormTitle.TabIndex = 0;
            this.lblArtistFormTitle.Text = "THÔNG TIN CA SĨ";
            this.lblArtistFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlArtistLeft
            // 
            this.pnlArtistLeft.Controls.Add(this.dgvArtists);
            this.pnlArtistLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlArtistLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlArtistLeft.Location = new System.Drawing.Point(0, 80);
            this.pnlArtistLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlArtistLeft.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlArtistLeft.Name = "pnlArtistLeft";
            this.pnlArtistLeft.Padding = new System.Windows.Forms.Padding(10);
            this.pnlArtistLeft.Size = new System.Drawing.Size(1150, 600);
            this.pnlArtistLeft.TabIndex = 1;
            this.pnlArtistLeft.Text = null;
            this.pnlArtistLeft.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvArtists
            // 
            this.dgvArtists.AllowUserToAddRows = false;
            this.dgvArtists.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvArtists.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArtists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArtists.BackgroundColor = System.Drawing.Color.White;
            this.dgvArtists.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtists.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArtists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArtists.EnableHeadersVisualStyles = false;
            this.dgvArtists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvArtists.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvArtists.Location = new System.Drawing.Point(10, 10);
            this.dgvArtists.MultiSelect = false;
            this.dgvArtists.Name = "dgvArtists";
            this.dgvArtists.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtists.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArtists.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvArtists.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArtists.RowTemplate.Height = 24;
            this.dgvArtists.SelectedIndex = -1;
            this.dgvArtists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtists.Size = new System.Drawing.Size(1130, 580);
            this.dgvArtists.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvArtists.TabIndex = 0;
            this.dgvArtists.SelectionChanged += new System.EventHandler(this.dgvArtists_SelectionChanged);
            // 
            // pnlArtistTop
            // 
            this.pnlArtistTop.Controls.Add(this.btnRefreshArtist);
            this.pnlArtistTop.Controls.Add(this.lblTotalArtists);
            this.pnlArtistTop.Controls.Add(this.txtSearchArtist);
            this.pnlArtistTop.Controls.Add(this.lblArtistTitle);
            this.pnlArtistTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArtistTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlArtistTop.Location = new System.Drawing.Point(0, 0);
            this.pnlArtistTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlArtistTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlArtistTop.Name = "pnlArtistTop";
            this.pnlArtistTop.Size = new System.Drawing.Size(1150, 80);
            this.pnlArtistTop.TabIndex = 0;
            this.pnlArtistTop.Text = null;
            this.pnlArtistTop.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefreshArtist
            // 
            this.btnRefreshArtist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRefreshArtist.Location = new System.Drawing.Point(1020, 30);
            this.btnRefreshArtist.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRefreshArtist.Name = "btnRefreshArtist";
            this.btnRefreshArtist.Size = new System.Drawing.Size(110, 35);
            this.btnRefreshArtist.Symbol = 61473;
            this.btnRefreshArtist.TabIndex = 3;
            this.btnRefreshArtist.Text = "Làm mới";
            this.btnRefreshArtist.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRefreshArtist.Click += new System.EventHandler(this.btnRefreshArtist_Click);
            // 
            // lblTotalArtists
            // 
            this.lblTotalArtists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotalArtists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTotalArtists.Location = new System.Drawing.Point(870, 35);
            this.lblTotalArtists.Name = "lblTotalArtists";
            this.lblTotalArtists.Size = new System.Drawing.Size(144, 25);
            this.lblTotalArtists.TabIndex = 2;
            this.lblTotalArtists.Text = "Tổng số: 0 ca sĩ";
            this.lblTotalArtists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearchArtist
            // 
            this.txtSearchArtist.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtSearchArtist.Location = new System.Drawing.Point(430, 30);
            this.txtSearchArtist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchArtist.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSearchArtist.Name = "txtSearchArtist";
            this.txtSearchArtist.Padding = new System.Windows.Forms.Padding(5);
            this.txtSearchArtist.ShowText = false;
            this.txtSearchArtist.Size = new System.Drawing.Size(420, 35);
            this.txtSearchArtist.TabIndex = 1;
            this.txtSearchArtist.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSearchArtist.Watermark = "Tìm kiếm ca sĩ...";
            this.txtSearchArtist.TextChanged += new System.EventHandler(this.txtSearchArtist_TextChanged);
            // 
            // lblArtistTitle
            // 
            this.lblArtistTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblArtistTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblArtistTitle.Location = new System.Drawing.Point(20, 20);
            this.lblArtistTitle.Name = "lblArtistTitle";
            this.lblArtistTitle.Size = new System.Drawing.Size(400, 45);
            this.lblArtistTitle.TabIndex = 0;
            this.lblArtistTitle.Text = "🎤 QUẢN LÝ CA SĨ";
            this.lblArtistTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabGenres
            // 
            this.tabGenres.BackColor = System.Drawing.Color.White;
            this.tabGenres.Controls.Add(this.pnlGenreRight);
            this.tabGenres.Controls.Add(this.pnlGenreLeft);
            this.tabGenres.Controls.Add(this.pnlGenreTop);
            this.tabGenres.Location = new System.Drawing.Point(0, 40);
            this.tabGenres.Name = "tabGenres";
            this.tabGenres.Size = new System.Drawing.Size(1150, 680);
            this.tabGenres.TabIndex = 1;
            this.tabGenres.Text = "🎼 Quản lý Thể loại";
            // 
            // pnlGenreRight
            // 
            this.pnlGenreRight.Controls.Add(this.txtGenreDesc);
            this.pnlGenreRight.Controls.Add(this.lblGenreDesc);
            this.pnlGenreRight.Controls.Add(this.txtGenreName);
            this.pnlGenreRight.Controls.Add(this.lblGenreName);
            this.pnlGenreRight.Controls.Add(this.btnDeleteGenre);
            this.pnlGenreRight.Controls.Add(this.btnUpdateGenre);
            this.pnlGenreRight.Controls.Add(this.btnAddGenre);
            this.pnlGenreRight.Controls.Add(this.lblGenreFormTitle);
            this.pnlGenreRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGenreRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlGenreRight.Location = new System.Drawing.Point(750, 80);
            this.pnlGenreRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlGenreRight.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlGenreRight.Name = "pnlGenreRight";
            this.pnlGenreRight.Padding = new System.Windows.Forms.Padding(10);
            this.pnlGenreRight.Size = new System.Drawing.Size(400, 600);
            this.pnlGenreRight.TabIndex = 2;
            this.pnlGenreRight.Text = null;
            this.pnlGenreRight.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGenreDesc
            // 
            this.txtGenreDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGenreDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtGenreDesc.Location = new System.Drawing.Point(20, 135);
            this.txtGenreDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGenreDesc.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtGenreDesc.Multiline = true;
            this.txtGenreDesc.Name = "txtGenreDesc";
            this.txtGenreDesc.Padding = new System.Windows.Forms.Padding(5);
            this.txtGenreDesc.ShowText = false;
            this.txtGenreDesc.Size = new System.Drawing.Size(360, 100);
            this.txtGenreDesc.TabIndex = 7;
            this.txtGenreDesc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtGenreDesc.Watermark = "Mô tả thể loại...";
            // 
            // lblGenreDesc
            // 
            this.lblGenreDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGenreDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblGenreDesc.Location = new System.Drawing.Point(20, 105);
            this.lblGenreDesc.Name = "lblGenreDesc";
            this.lblGenreDesc.Size = new System.Drawing.Size(200, 25);
            this.lblGenreDesc.TabIndex = 6;
            this.lblGenreDesc.Text = "Mô tả:";
            this.lblGenreDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGenreName
            // 
            this.txtGenreName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGenreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtGenreName.Location = new System.Drawing.Point(20, 65);
            this.txtGenreName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGenreName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.Padding = new System.Windows.Forms.Padding(5);
            this.txtGenreName.ShowText = false;
            this.txtGenreName.Size = new System.Drawing.Size(360, 35);
            this.txtGenreName.TabIndex = 5;
            this.txtGenreName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtGenreName.Watermark = "Nhập tên thể loại";
            // 
            // lblGenreName
            // 
            this.lblGenreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGenreName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblGenreName.Location = new System.Drawing.Point(20, 35);
            this.lblGenreName.Name = "lblGenreName";
            this.lblGenreName.Size = new System.Drawing.Size(200, 25);
            this.lblGenreName.TabIndex = 4;
            this.lblGenreName.Text = "Tên thể loại: *";
            this.lblGenreName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeleteGenre
            // 
            this.btnDeleteGenre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteGenre.Location = new System.Drawing.Point(270, 255);
            this.btnDeleteGenre.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.btnDeleteGenre.Size = new System.Drawing.Size(110, 45);
            this.btnDeleteGenre.TabIndex = 3;
            this.btnDeleteGenre.Text = "🗑️ Xóa";
            this.btnDeleteGenre.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDeleteGenre.Click += new System.EventHandler(this.btnDeleteGenre_Click);
            // 
            // btnUpdateGenre
            // 
            this.btnUpdateGenre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdateGenre.Location = new System.Drawing.Point(145, 255);
            this.btnUpdateGenre.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpdateGenre.Name = "btnUpdateGenre";
            this.btnUpdateGenre.Size = new System.Drawing.Size(110, 45);
            this.btnUpdateGenre.TabIndex = 2;
            this.btnUpdateGenre.Text = "✏️ Sửa";
            this.btnUpdateGenre.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnUpdateGenre.Click += new System.EventHandler(this.btnUpdateGenre_Click);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddGenre.Location = new System.Drawing.Point(20, 255);
            this.btnAddGenre.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(110, 45);
            this.btnAddGenre.TabIndex = 1;
            this.btnAddGenre.Text = "➕ Thêm";
            this.btnAddGenre.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // lblGenreFormTitle
            // 
            this.lblGenreFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGenreFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblGenreFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblGenreFormTitle.Location = new System.Drawing.Point(10, 10);
            this.lblGenreFormTitle.Name = "lblGenreFormTitle";
            this.lblGenreFormTitle.Size = new System.Drawing.Size(380, 35);
            this.lblGenreFormTitle.TabIndex = 0;
            this.lblGenreFormTitle.Text = "THÔNG TIN THỂ LOẠI";
            this.lblGenreFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGenreLeft
            // 
            this.pnlGenreLeft.Controls.Add(this.dgvGenres);
            this.pnlGenreLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGenreLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlGenreLeft.Location = new System.Drawing.Point(0, 80);
            this.pnlGenreLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlGenreLeft.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlGenreLeft.Name = "pnlGenreLeft";
            this.pnlGenreLeft.Padding = new System.Windows.Forms.Padding(10);
            this.pnlGenreLeft.Size = new System.Drawing.Size(1150, 600);
            this.pnlGenreLeft.TabIndex = 1;
            this.pnlGenreLeft.Text = null;
            this.pnlGenreLeft.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvGenres
            // 
            this.dgvGenres.AllowUserToAddRows = false;
            this.dgvGenres.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvGenres.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGenres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGenres.BackgroundColor = System.Drawing.Color.White;
            this.dgvGenres.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGenres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGenres.EnableHeadersVisualStyles = false;
            this.dgvGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvGenres.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvGenres.Location = new System.Drawing.Point(10, 10);
            this.dgvGenres.MultiSelect = false;
            this.dgvGenres.Name = "dgvGenres";
            this.dgvGenres.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGenres.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvGenres.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvGenres.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvGenres.RowTemplate.Height = 24;
            this.dgvGenres.SelectedIndex = -1;
            this.dgvGenres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGenres.Size = new System.Drawing.Size(1130, 580);
            this.dgvGenres.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvGenres.TabIndex = 0;
            this.dgvGenres.SelectionChanged += new System.EventHandler(this.dgvGenres_SelectionChanged);
            // 
            // pnlGenreTop
            // 
            this.pnlGenreTop.Controls.Add(this.btnRefreshGenre);
            this.pnlGenreTop.Controls.Add(this.lblTotalGenres);
            this.pnlGenreTop.Controls.Add(this.lblGenreTitle);
            this.pnlGenreTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGenreTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlGenreTop.Location = new System.Drawing.Point(0, 0);
            this.pnlGenreTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlGenreTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlGenreTop.Name = "pnlGenreTop";
            this.pnlGenreTop.Size = new System.Drawing.Size(1150, 80);
            this.pnlGenreTop.TabIndex = 0;
            this.pnlGenreTop.Text = null;
            this.pnlGenreTop.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefreshGenre
            // 
            this.btnRefreshGenre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRefreshGenre.Location = new System.Drawing.Point(1050, 30);
            this.btnRefreshGenre.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRefreshGenre.Name = "btnRefreshGenre";
            this.btnRefreshGenre.Size = new System.Drawing.Size(80, 35);
            this.btnRefreshGenre.Symbol = 61473;
            this.btnRefreshGenre.TabIndex = 2;
            this.btnRefreshGenre.Text = "Làm mới";
            this.btnRefreshGenre.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRefreshGenre.Click += new System.EventHandler(this.btnRefreshGenre_Click);
            // 
            // lblTotalGenres
            // 
            this.lblTotalGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotalGenres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTotalGenres.Location = new System.Drawing.Point(870, 35);
            this.lblTotalGenres.Name = "lblTotalGenres";
            this.lblTotalGenres.Size = new System.Drawing.Size(160, 25);
            this.lblTotalGenres.TabIndex = 1;
            this.lblTotalGenres.Text = "Tổng số: 0 thể loại";
            this.lblTotalGenres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGenreTitle
            // 
            this.lblGenreTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblGenreTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblGenreTitle.Location = new System.Drawing.Point(20, 20);
            this.lblGenreTitle.Name = "lblGenreTitle";
            this.lblGenreTitle.Size = new System.Drawing.Size(400, 45);
            this.lblGenreTitle.TabIndex = 0;
            this.lblGenreTitle.Text = "🎼 QUẢN LÝ THỂ LOẠI";
            this.lblGenreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ArtistGenreManagementForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1150, 755);
            this.Controls.Add(this.tabControl);
            this.Name = "ArtistGenreManagementForm";
            this.Text = "Quản lý Ca sĩ & Thể loại";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 1150, 755);
            this.Load += new System.EventHandler(this.ArtistGenreManagementForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabArtists.ResumeLayout(false);
            this.pnlArtistRight.ResumeLayout(false);
            this.pnlArtistLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtists)).EndInit();
            this.pnlArtistTop.ResumeLayout(false);
            this.tabGenres.ResumeLayout(false);
            this.pnlGenreRight.ResumeLayout(false);
            this.pnlGenreLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).EndInit();
            this.pnlGenreTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControl tabControl;
        private System.Windows.Forms.TabPage tabArtists;
        private System.Windows.Forms.TabPage tabGenres;
        private Sunny.UI.UIPanel pnlArtistTop;
        private Sunny.UI.UIPanel pnlArtistLeft;
        private Sunny.UI.UIPanel pnlArtistRight;
        private Sunny.UI.UILabel lblArtistTitle;
        private Sunny.UI.UITextBox txtSearchArtist;
        private Sunny.UI.UILabel lblTotalArtists;
        private Sunny.UI.UIDataGridView dgvArtists;
        private Sunny.UI.UILabel lblArtistFormTitle;
        private Sunny.UI.UIButton btnAddArtist;
        private Sunny.UI.UIButton btnUpdateArtist;
        private Sunny.UI.UIButton btnDeleteArtist;
        private Sunny.UI.UILabel lblArtistName;
        private Sunny.UI.UITextBox txtArtistName;
        private Sunny.UI.UILabel lblCountry;
        private Sunny.UI.UITextBox txtCountry;
        private Sunny.UI.UILabel lblBiography;
        private Sunny.UI.UITextBox txtBiography;
        private Sunny.UI.UIPanel pnlGenreTop;
        private Sunny.UI.UIPanel pnlGenreLeft;
        private Sunny.UI.UIPanel pnlGenreRight;
        private Sunny.UI.UILabel lblGenreTitle;
        private Sunny.UI.UILabel lblTotalGenres;
        private Sunny.UI.UIDataGridView dgvGenres;
        private Sunny.UI.UILabel lblGenreFormTitle;
        private Sunny.UI.UIButton btnAddGenre;
        private Sunny.UI.UIButton btnUpdateGenre;
        private Sunny.UI.UIButton btnDeleteGenre;
        private Sunny.UI.UILabel lblGenreName;
        private Sunny.UI.UITextBox txtGenreName;
        private Sunny.UI.UILabel lblGenreDesc;
        private Sunny.UI.UITextBox txtGenreDesc;
        private Sunny.UI.UISymbolButton btnRefreshArtist;
        private Sunny.UI.UISymbolButton btnRefreshGenre;
    }
}

