using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Sunny.UI;
using MusicLibraryManager.BUS;
using MusicLibraryManager.Entities;
using MusicLibraryManager.Helpers;

namespace MusicLibraryManager.GUI
{
    public partial class ArtistGenreManagementForm : UIForm
    {
        private List<Artist> artistList;
        private List<Genre> genreList;

        public ArtistGenreManagementForm()
        {
            InitializeComponent();
        }

        private void ArtistGenreManagementForm_Load(object sender, EventArgs e)
        {
            LoadArtists();
            LoadGenres();
        }

        #region Artist Management

        private void LoadArtists()
        {
            try
            {
                artistList = ArtistBUS.GetAllArtists();
                dgvArtists.DataSource = null;
                dgvArtists.DataSource = artistList;
                ConfigureArtistDataGridView();
                dgvArtists.Refresh();
                lblTotalArtists.Text = $"Tổng số: {artistList.Count} ca sĩ";
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi khi tải danh sách ca sĩ: {ex.Message}");
            }
        }

        private void ConfigureArtistDataGridView()
        {
            dgvArtists.Columns["ArtistID"].HeaderText = "ID";
            dgvArtists.Columns["ArtistID"].Width = 50;
            dgvArtists.Columns["ArtistName"].HeaderText = "Tên ca sĩ";
            dgvArtists.Columns["ArtistName"].Width = 200;
            dgvArtists.Columns["Country"].HeaderText = "Quốc gia";
            dgvArtists.Columns["Country"].Width = 120;
            dgvArtists.Columns["Biography"].HeaderText = "Tiểu sử";
            dgvArtists.Columns["Biography"].Width = 250;

            dgvArtists.Columns["ImagePath"].Visible = false;
            dgvArtists.Columns["CreatedDate"].Visible = false;
            dgvArtists.Columns["UpdatedDate"].Visible = false;
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArtistName.Text))
            {
                UIHelper.ShowWarning("Vui lòng nhập tên ca sĩ!");
                return;
            }

            try
            {
                Artist newArtist = new Artist
                {
                    ArtistName = txtArtistName.Text.Trim(),
                    Country = txtCountry.Text.Trim(),
                    Biography = txtBiography.Text.Trim()
                };

                int newID = ArtistBUS.AddArtist(newArtist);
                UIHelper.ShowSuccess($"Đã thêm ca sĩ thành công! ID: {newID}");
                LoadArtists();
                ClearArtistForm();
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi: {ex.Message}");
            }
        }

        private void btnUpdateArtist_Click(object sender, EventArgs e)
        {
            if (dgvArtists.SelectedRows.Count == 0)
            {
                UIHelper.ShowWarning("Vui lòng chọn ca sĩ cần sửa!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtArtistName.Text))
            {
                UIHelper.ShowWarning("Vui lòng nhập tên ca sĩ!");
                return;
            }

            // Thêm dialog xác nhận
            if (!UIHelper.ShowUpdateConfirm("ca sĩ"))
            {
                return;
            }

            try
            {
                int artistID = Convert.ToInt32(dgvArtists.SelectedRows[0].Cells["ArtistID"].Value);
                Artist artist = new Artist
                {
                    ArtistID = artistID,
                    ArtistName = txtArtistName.Text.Trim(),
                    Country = txtCountry.Text.Trim(),
                    Biography = txtBiography.Text.Trim()
                };

                bool success = ArtistBUS.UpdateArtist(artist);
                if (success)
                {
                    // Hiện thông báo NGAY
                    UIHelper.ShowSuccess("Đã cập nhật ca sĩ thành công!");
                    
                    // Clear form và selection
                    dgvArtists.ClearSelection();
                    ClearArtistForm();
                    
                    // Suspend layout để tránh flicker
                    dgvArtists.SuspendLayout();
                    
                    // Load lại data từ DB
                    LoadArtists();
                    
                    // Resume layout và force refresh
                    dgvArtists.ResumeLayout();
                    dgvArtists.Refresh();
                    Application.DoEvents();
                }
                else
                {
                    UIHelper.ShowWarning("Cập nhật thất bại! Vui lòng thử lại.");
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi: {ex.Message}");
            }
        }

        private void btnDeleteArtist_Click(object sender, EventArgs e)
        {
            if (dgvArtists.SelectedRows.Count == 0)
            {
                UIHelper.ShowWarning("Vui lòng chọn ca sĩ cần xóa!");
                return;
            }

            if (UIHelper.ShowDeleteConfirm("ca sĩ"))
            {
                try
                {
                    int artistID = Convert.ToInt32(dgvArtists.SelectedRows[0].Cells["ArtistID"].Value);
                    bool success = ArtistBUS.DeleteArtist(artistID);
                    
                    if (success)
                    {
                        UIHelper.ShowSuccess("Đã xóa ca sĩ thành công!");
                        LoadArtists();
                        ClearArtistForm();
                    }
                }
                catch (Exception ex)
                {
                    UIHelper.ShowError($"Lỗi: {ex.Message}");
                }
            }
        }

        private void dgvArtists_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArtists.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dgvArtists.SelectedRows[0];
                    txtArtistName.Text = row.Cells["ArtistName"].Value.ToString();
                    txtCountry.Text = row.Cells["Country"].Value != DBNull.Value ? 
                                      row.Cells["Country"].Value.ToString() : "";
                    txtBiography.Text = row.Cells["Biography"].Value != DBNull.Value ? 
                                        row.Cells["Biography"].Value.ToString() : "";
                }
                catch { }
            }
        }

        private void txtSearchArtist_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearchArtist.Text.Trim();
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    LoadArtists();
                }
                else
                {
                    artistList = ArtistBUS.SearchArtists(searchTerm);
                    dgvArtists.DataSource = null;
                    dgvArtists.DataSource = artistList;
                    ConfigureArtistDataGridView();
                    lblTotalArtists.Text = $"Tìm thấy: {artistList.Count} ca sĩ";
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi khi tìm kiếm: {ex.Message}");
            }
        }

        private void ClearArtistForm()
        {
            txtArtistName.Clear();
            txtCountry.Clear();
            txtBiography.Clear();
            txtArtistName.Focus();
        }

        #endregion

        #region Genre Management

        private void LoadGenres()
        {
            try
            {
                genreList = GenreBUS.GetAllGenres();
                dgvGenres.DataSource = null;
                dgvGenres.DataSource = genreList;
                ConfigureGenreDataGridView();
                dgvGenres.Refresh();
                lblTotalGenres.Text = $"Tổng số: {genreList.Count} thể loại";
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi khi tải danh sách thể loại: {ex.Message}");
            }
        }

        private void ConfigureGenreDataGridView()
        {
            dgvGenres.Columns["GenreID"].HeaderText = "ID";
            dgvGenres.Columns["GenreID"].Width = 50;
            dgvGenres.Columns["GenreName"].HeaderText = "Tên thể loại";
            dgvGenres.Columns["GenreName"].Width = 150;
            dgvGenres.Columns["Description"].HeaderText = "Mô tả";
            dgvGenres.Columns["Description"].Width = 300;

            dgvGenres.Columns["CreatedDate"].Visible = false;
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGenreName.Text))
            {
                UIHelper.ShowWarning("Vui lòng nhập tên thể loại!");
                return;
            }

            try
            {
                Genre newGenre = new Genre
                {
                    GenreName = txtGenreName.Text.Trim(),
                    Description = txtGenreDesc.Text.Trim()
                };

                int newID = GenreBUS.AddGenre(newGenre);
                UIHelper.ShowSuccess($"Đã thêm thể loại thành công! ID: {newID}");
                LoadGenres();
                ClearGenreForm();
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi: {ex.Message}");
            }
        }

        private void btnUpdateGenre_Click(object sender, EventArgs e)
        {
            if (dgvGenres.SelectedRows.Count == 0)
            {
                UIHelper.ShowWarning("Vui lòng chọn thể loại cần sửa!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGenreName.Text))
            {
                UIHelper.ShowWarning("Vui lòng nhập tên thể loại!");
                return;
            }

            // Thêm dialog xác nhận
            if (!UIHelper.ShowUpdateConfirm("thể loại"))
            {
                return;
            }

            try
            {
                int genreID = Convert.ToInt32(dgvGenres.SelectedRows[0].Cells["GenreID"].Value);
                Genre genre = new Genre
                {
                    GenreID = genreID,
                    GenreName = txtGenreName.Text.Trim(),
                    Description = txtGenreDesc.Text.Trim()
                };

                bool success = GenreBUS.UpdateGenre(genre);
                if (success)
                {
                    // Clear form và selection TRƯỚC
                    dgvGenres.ClearSelection();
                    ClearGenreForm();
                    
                    // Suspend layout để tránh flicker
                    dgvGenres.SuspendLayout();
                    
                    // Load lại data
                    LoadGenres();
                    
                    // Resume layout
                    dgvGenres.ResumeLayout();
                    dgvGenres.Refresh();
                    
                    // Force update
                    Application.DoEvents();
                    
                    UIHelper.ShowSuccess("Đã cập nhật thể loại thành công!");
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi: {ex.Message}");
            }
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            if (dgvGenres.SelectedRows.Count == 0)
            {
                UIHelper.ShowWarning("Vui lòng chọn thể loại cần xóa!");
                return;
            }

            if (UIHelper.ShowDeleteConfirm("thể loại"))
            {
                try
                {
                    int genreID = Convert.ToInt32(dgvGenres.SelectedRows[0].Cells["GenreID"].Value);
                    bool success = GenreBUS.DeleteGenre(genreID);
                    
                    if (success)
                    {
                        UIHelper.ShowSuccess("Đã xóa thể loại thành công!");
                        LoadGenres();
                        ClearGenreForm();
                    }
                }
                catch (Exception ex)
                {
                    UIHelper.ShowError($"Lỗi: {ex.Message}");
                }
            }
        }

        private void dgvGenres_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGenres.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dgvGenres.SelectedRows[0];
                    txtGenreName.Text = row.Cells["GenreName"].Value.ToString();
                    txtGenreDesc.Text = row.Cells["Description"].Value != DBNull.Value ? 
                                        row.Cells["Description"].Value.ToString() : "";
                }
                catch { }
            }
        }

        private void ClearGenreForm()
        {
            txtGenreName.Clear();
            txtGenreDesc.Clear();
            txtGenreName.Focus();
        }

        #endregion

        private void btnRefreshArtist_Click(object sender, EventArgs e)
        {
            LoadArtists();
            ClearArtistForm();
        }

        private void btnRefreshGenre_Click(object sender, EventArgs e)
        {
            LoadGenres();
            ClearGenreForm();
        }
    }
}

