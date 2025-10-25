using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Sunny.UI;
using MusicLibraryManager.BUS;
using MusicLibraryManager.Entities;
using MusicLibraryManager.Helpers;

namespace MusicLibraryManager.GUI
{
    public partial class SongManagementForm : UIForm
    {
        private List<Song> songList;
        private List<Artist> artistList;
        private List<Genre> genreList;

        public SongManagementForm()
        {
            InitializeComponent();
        }

        private void SongManagementForm_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBoxData();
        }

        private void LoadData()
        {
            try
            {
                songList = SongBUS.GetAllSongs();
                dgvSongs.DataSource = null;
                dgvSongs.DataSource = songList;
                ConfigureDataGridView();
                dgvSongs.Refresh();
                lblTotalSongs.Text = $"Tổng số: {songList.Count} bài hát";
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi khi tải dữ liệu: {ex.Message}");
            }
        }

        private void LoadComboBoxData()
        {
            try
            {
                // Load artists
                artistList = ArtistBUS.GetAllArtists();
                cboArtist.DataSource = new List<Artist>(artistList);
                cboArtist.DisplayMember = "ArtistName";
                cboArtist.ValueMember = "ArtistID";
                cboArtist.SelectedIndex = -1;

                // Load genres
                genreList = GenreBUS.GetAllGenres();
                cboGenre.DataSource = new List<Genre>(genreList);
                cboGenre.DisplayMember = "GenreName";
                cboGenre.ValueMember = "GenreID";
                cboGenre.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi khi tải danh sách: {ex.Message}");
            }
        }

        private void ConfigureDataGridView()
        {
            // Đặt AutoSizeMode trước
            dgvSongs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;

            // Ẩn các cột không cần thiết (check xem có tồn tại không trước)
            HideColumnIfExists("ArtistID");
            HideColumnIfExists("AlbumID");
            HideColumnIfExists("GenreID");
            HideColumnIfExists("FilePath");
            HideColumnIfExists("Duration");
            HideColumnIfExists("Lyrics");
            HideColumnIfExists("FileSize");
            HideColumnIfExists("BitRate");
            HideColumnIfExists("CreatedDate");
            HideColumnIfExists("LastPlayedDate");
            HideColumnIfExists("AlbumName");
            HideColumnIfExists("Rating");
            HideColumnIfExists("ReleaseYear");
            HideColumnIfExists("FileSizeFormatted");
            HideColumnIfExists("PlayCount");

            // Cấu hình các cột hiển thị
            if (dgvSongs.Columns.Contains("SongID"))
            {
                dgvSongs.Columns["SongID"].HeaderText = "ID";
                dgvSongs.Columns["SongID"].Width = 50;
                dgvSongs.Columns["SongID"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            }

            if (dgvSongs.Columns.Contains("SongTitle"))
            {
                dgvSongs.Columns["SongTitle"].HeaderText = "Tên bài hát";
                dgvSongs.Columns["SongTitle"].Width = 280;
                dgvSongs.Columns["SongTitle"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            }

            if (dgvSongs.Columns.Contains("ArtistName"))
            {
                dgvSongs.Columns["ArtistName"].HeaderText = "Ca sĩ";
                dgvSongs.Columns["ArtistName"].Width = 150;
                dgvSongs.Columns["ArtistName"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            }

            if (dgvSongs.Columns.Contains("GenreName"))
            {
                dgvSongs.Columns["GenreName"].HeaderText = "Thể loại";
                dgvSongs.Columns["GenreName"].Width = 110;
                dgvSongs.Columns["GenreName"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            }

            if (dgvSongs.Columns.Contains("DurationFormatted"))
            {
                dgvSongs.Columns["DurationFormatted"].HeaderText = "Thời lượng";
                dgvSongs.Columns["DurationFormatted"].Width = 90;
                dgvSongs.Columns["DurationFormatted"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            }

            if (dgvSongs.Columns.Contains("IsFavorite"))
            {
                dgvSongs.Columns["IsFavorite"].HeaderText = "❤️";
                dgvSongs.Columns["IsFavorite"].Width = 50;
                dgvSongs.Columns["IsFavorite"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            }
        }

        private void HideColumnIfExists(string columnName)
        {
            if (dgvSongs.Columns.Contains(columnName))
            {
                dgvSongs.Columns[columnName].Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                string filePath = txtFilePath.Text.Trim();
                
                Song newSong = new Song
                {
                    SongTitle = txtTitle.Text.Trim(),
                    ArtistID = cboArtist.SelectedIndex >= 0 ? (int?)cboArtist.SelectedValue : null,
                    GenreID = cboGenre.SelectedIndex >= 0 ? (int?)cboGenre.SelectedValue : null,
                    FilePath = filePath,
                    ReleaseYear = string.IsNullOrWhiteSpace(txtYear.Text) ? (int?)null : int.Parse(txtYear.Text),
                    Duration = MediaHelper.GetMediaDuration(filePath),
                    FileSize = MediaHelper.GetFileSize(filePath)
                };

                int newID = SongBUS.AddSong(newSong);
                UIHelper.ShowSuccess($"Đã thêm bài hát thành công! ID: {newID}");
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi khi thêm bài hát: {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSongs.SelectedRows.Count == 0)
            {
                UIHelper.ShowWarning("Vui lòng chọn bài hát cần sửa!");
                return;
            }

            if (!ValidateInput()) return;

            // Thêm dialog xác nhận
            if (!UIHelper.ShowUpdateConfirm("bài hát"))
            {
                return;
            }

            try
            {
                int songID = Convert.ToInt32(dgvSongs.SelectedRows[0].Cells["SongID"].Value);
                Song song = SongBUS.GetSongByID(songID);
                
                song.SongTitle = txtTitle.Text.Trim();
                song.ArtistID = cboArtist.SelectedIndex >= 0 ? (int?)cboArtist.SelectedValue : null;
                song.GenreID = cboGenre.SelectedIndex >= 0 ? (int?)cboGenre.SelectedValue : null;
                song.ReleaseYear = string.IsNullOrWhiteSpace(txtYear.Text) ? (int?)null : int.Parse(txtYear.Text);

                bool success = SongBUS.UpdateSong(song);
                if (success)
                {
                    // Clear form và selection TRƯỚC
                    dgvSongs.ClearSelection();
                    ClearForm();
                    
                    // Suspend layout để tránh flicker
                    dgvSongs.SuspendLayout();
                    
                    // Load lại data
                    LoadData();
                    
                    // Resume layout
                    dgvSongs.ResumeLayout();
                    dgvSongs.Refresh();
                    
                    // Force update
                    Application.DoEvents();
                    
                    UIHelper.ShowSuccess("Đã cập nhật bài hát thành công!");
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi khi cập nhật: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSongs.SelectedRows.Count == 0)
            {
                UIHelper.ShowWarning("Vui lòng chọn bài hát cần xóa!");
                return;
            }

            if (UIHelper.ShowDeleteConfirm("bài hát"))
            {
                try
                {
                    int songID = Convert.ToInt32(dgvSongs.SelectedRows[0].Cells["SongID"].Value);
                    bool success = SongBUS.DeleteSong(songID);
                    
                    if (success)
                    {
                        UIHelper.ShowSuccess("Đã xóa bài hát thành công!");
                        LoadData();
                        ClearForm();
                    }
                }
                catch (Exception ex)
                {
                    UIHelper.ShowError($"Lỗi khi xóa: {ex.Message}");
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "All Media Files|*.mp3;*.mp4;*.wav;*.wma;*.flac;*.m4a;*.aac;*.avi;*.wmv;*.mkv;*.mov|" +
                             "Audio Files|*.mp3;*.wav;*.wma;*.flac;*.m4a;*.aac|" +
                             "Video Files|*.mp4;*.avi;*.wmv;*.mkv;*.mov|" +
                             "All Files|*.*";
                ofd.Title = "Chọn file nhạc hoặc video";
                
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = ofd.FileName;
                    
                    // Tự động điền tên bài hát nếu chưa có
                    if (string.IsNullOrWhiteSpace(txtTitle.Text))
                    {
                        txtTitle.Text = System.IO.Path.GetFileNameWithoutExtension(ofd.FileName);
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearch.Text.Trim();
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    LoadData();
                }
                else
                {
                    songList = SongBUS.SearchSongs(searchTerm);
                    dgvSongs.DataSource = null;
                    dgvSongs.DataSource = songList;
                    ConfigureDataGridView();
                    lblTotalSongs.Text = $"Tìm thấy: {songList.Count} bài hát";
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi khi tìm kiếm: {ex.Message}");
            }
        }

        private void dgvSongs_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSongs.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dgvSongs.SelectedRows[0];
                    
                    // Lấy SongID để load chi tiết từ DB
                    int songID = Convert.ToInt32(row.Cells["SongID"].Value);
                    Song selectedSong = SongBUS.GetSongByID(songID);
                    
                    if (selectedSong != null)
                    {
                        txtTitle.Text = selectedSong.SongTitle;
                        txtFilePath.Text = selectedSong.FilePath ?? "";
                        txtYear.Text = selectedSong.ReleaseYear?.ToString() ?? "";

                        // Set combo boxes
                        if (selectedSong.ArtistID.HasValue)
                        {
                            cboArtist.SelectedValue = selectedSong.ArtistID.Value;
                        }
                        else
                        {
                            cboArtist.SelectedIndex = -1;
                        }

                        if (selectedSong.GenreID.HasValue)
                        {
                            cboGenre.SelectedValue = selectedSong.GenreID.Value;
                        }
                        else
                        {
                            cboGenre.SelectedIndex = -1;
                        }
                    }
                }
                catch { }
            }
        }

        private void btnToggleFavorite_Click(object sender, EventArgs e)
        {
            if (dgvSongs.SelectedRows.Count == 0)
            {
                UIHelper.ShowWarning("Vui lòng chọn bài hát!");
                return;
            }

            try
            {
                int songID = Convert.ToInt32(dgvSongs.SelectedRows[0].Cells["SongID"].Value);
                SongBUS.ToggleFavorite(songID);
                LoadData();
                UIHelper.ShowSuccess("Đã cập nhật yêu thích!");
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi: {ex.Message}");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearForm();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                UIHelper.ShowWarning("Vui lòng nhập tên bài hát!");
                txtTitle.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFilePath.Text))
            {
                UIHelper.ShowWarning("Vui lòng chọn file nhạc!");
                return false;
            }

            if (!SongBUS.IsValidMusicFile(txtFilePath.Text))
            {
                UIHelper.ShowWarning("File nhạc không hợp lệ hoặc không tồn tại!");
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtTitle.Clear();
            txtFilePath.Clear();
            txtYear.Clear();
            cboArtist.SelectedIndex = -1;
            cboGenre.SelectedIndex = -1;
            txtTitle.Focus();
        }

        private void lblSongTitle_Click(object sender, EventArgs e)
        {

        }

        private void dgvSongs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                // Lấy bài hát được double-click
                int songID = Convert.ToInt32(dgvSongs.Rows[e.RowIndex].Cells["SongID"].Value);
                Song selectedSong = SongBUS.GetSongByID(songID);

                if (selectedSong != null)
                {
                    // Tạo playlist với tất cả bài hát hiện tại
                    List<Song> allSongs = SongBUS.GetAllSongs();
                    
                    // Tìm index của bài hát được chọn
                    int startIndex = allSongs.FindIndex(s => s.SongID == songID);
                    
                    // Set playlist và phát
                    PlaybackManager.SetPlaylist(allSongs, startIndex);
                    
                    UIHelper.ShowSuccess($"Đang phát: {selectedSong.SongTitle}");
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi khi phát nhạc: {ex.Message}");
            }
        }

        private void dgvSongs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

