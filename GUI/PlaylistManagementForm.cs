using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Sunny.UI;
using MusicLibraryManager.BUS;
using MusicLibraryManager.Entities;
using MusicLibraryManager.Helpers;

namespace MusicLibraryManager.GUI
{
    public partial class PlaylistManagementForm : UIForm
    {
        private List<Playlist> playlistList;
        private List<Song> songList;
        private List<Song> playlistSongs;
        private int currentPlaylistID = -1;

        public PlaylistManagementForm()
        {
            InitializeComponent();
        }

        private void PlaylistManagementForm_Load(object sender, EventArgs e)
        {
            LoadPlaylists();
            LoadAllSongs();
        }

        private void LoadPlaylists()
        {
            try
            {
                playlistList = PlaylistBUS.GetAllPlaylists();
                dgvPlaylists.DataSource = null;
                dgvPlaylists.DataSource = playlistList;
                ConfigurePlaylistDataGridView();
                dgvPlaylists.Refresh();
                lblTotalPlaylists.Text = $"Tổng số: {playlistList.Count} playlist";
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi khi tải danh sách playlist: {ex.Message}");
            }
        }

        private void LoadAllSongs()
        {
            try
            {
                songList = SongBUS.GetAllSongs();
                dgvAllSongs.DataSource = null;
                dgvAllSongs.DataSource = songList;
                ConfigureAllSongsDataGridView();
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi khi tải danh sách bài hát: {ex.Message}");
            }
        }

        private void LoadPlaylistSongs(int playlistID)
        {
            try
            {
                playlistSongs = PlaylistBUS.GetPlaylistSongs(playlistID);
                dgvPlaylistSongs.DataSource = null;
                dgvPlaylistSongs.DataSource = playlistSongs;
                ConfigurePlaylistSongsDataGridView();
                lblTotalSongsInPlaylist.Text = $"Tổng số: {playlistSongs.Count} bài hát";
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi khi tải bài hát trong playlist: {ex.Message}");
            }
        }

        private void ConfigurePlaylistDataGridView()
        {
            dgvPlaylists.Columns["PlaylistID"].HeaderText = "ID";
            dgvPlaylists.Columns["PlaylistID"].Width = 50;
            dgvPlaylists.Columns["PlaylistName"].HeaderText = "Tên playlist";
            dgvPlaylists.Columns["PlaylistName"].Width = 200;
            dgvPlaylists.Columns["Description"].HeaderText = "Mô tả";
            dgvPlaylists.Columns["Description"].Width = 200;
            dgvPlaylists.Columns["SongCount"].HeaderText = "Số bài hát";
            dgvPlaylists.Columns["SongCount"].Width = 100;

            dgvPlaylists.Columns["CoverImagePath"].Visible = false;
            dgvPlaylists.Columns["IsPublic"].Visible = false;
            dgvPlaylists.Columns["CreatedDate"].Visible = false;
            dgvPlaylists.Columns["UpdatedDate"].Visible = false;
        }

        private void ConfigureAllSongsDataGridView()
        {
            // Chỉ hiện 3 cột: ID, Tên bài hát, Ca sĩ
            dgvAllSongs.Columns["SongID"].HeaderText = "ID";
            dgvAllSongs.Columns["SongID"].Width = 30;
            
            dgvAllSongs.Columns["SongTitle"].HeaderText = "Tên bài hát";
            dgvAllSongs.Columns["SongTitle"].Width = 110;
            dgvAllSongs.Columns["SongTitle"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            dgvAllSongs.Columns["ArtistName"].HeaderText = "Ca sĩ";
            dgvAllSongs.Columns["ArtistName"].Width = 200;

            // Ẩn tất cả cột khác
            foreach (DataGridViewColumn col in dgvAllSongs.Columns)
            {
                if (col.Name != "SongID" && col.Name != "SongTitle" && col.Name != "ArtistName")
                {
                    col.Visible = false;
                }
            }
        }

        private void ConfigurePlaylistSongsDataGridView()
        {
            // Chỉ hiện 3 cột: ID, Tên bài hát, Ca sĩ
            dgvPlaylistSongs.Columns["SongID"].HeaderText = "ID";
            dgvPlaylistSongs.Columns["SongID"].Width = 30;
            
            dgvPlaylistSongs.Columns["SongTitle"].HeaderText = "Tên bài hát";
            dgvPlaylistSongs.Columns["SongTitle"].Width = 110;
            dgvPlaylistSongs.Columns["SongTitle"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            dgvPlaylistSongs.Columns["ArtistName"].HeaderText = "Ca sĩ";
            dgvPlaylistSongs.Columns["ArtistName"].Width = 200;

            // Ẩn tất cả cột khác
            foreach (DataGridViewColumn col in dgvPlaylistSongs.Columns)
            {
                if (col.Name != "SongID" && col.Name != "SongTitle" && col.Name != "ArtistName")
                {
                    col.Visible = false;
                }
            }
        }

        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlaylistName.Text))
            {
                UIHelper.ShowWarning("Vui lòng nhập tên playlist!");
                return;
            }

            try
            {
                Playlist newPlaylist = new Playlist
                {
                    PlaylistName = txtPlaylistName.Text.Trim(),
                    Description = txtDescription.Text.Trim()
                };

                int newID = PlaylistBUS.CreatePlaylist(newPlaylist);
                UIHelper.ShowSuccess($"Đã tạo playlist thành công! ID: {newID}");
                LoadPlaylists();
                ClearForm();
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi: {ex.Message}");
            }
        }

        private void btnUpdatePlaylist_Click(object sender, EventArgs e)
        {
            if (dgvPlaylists.SelectedRows.Count == 0)
            {
                UIHelper.ShowWarning("Vui lòng chọn playlist cần sửa!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPlaylistName.Text))
            {
                UIHelper.ShowWarning("Vui lòng nhập tên playlist!");
                return;
            }

            // Thêm dialog xác nhận
            if (!UIHelper.ShowUpdateConfirm("playlist"))
            {
                return;
            }

            try
            {
                int playlistID = Convert.ToInt32(dgvPlaylists.SelectedRows[0].Cells["PlaylistID"].Value);
                Playlist playlist = new Playlist
                {
                    PlaylistID = playlistID,
                    PlaylistName = txtPlaylistName.Text.Trim(),
                    Description = txtDescription.Text.Trim()
                };

                bool success = PlaylistBUS.UpdatePlaylist(playlist);
                if (success)
                {
                    // Clear form và selection TRƯỚC
                    dgvPlaylists.ClearSelection();
                    ClearForm();
                    
                    // Suspend layout để tránh flicker
                    dgvPlaylists.SuspendLayout();
                    
                    // Load lại data
                    LoadPlaylists();
                    
                    // Resume layout
                    dgvPlaylists.ResumeLayout();
                    dgvPlaylists.Refresh();
                    
                    // Force update
                    Application.DoEvents();
                    
                    UIHelper.ShowSuccess("Đã cập nhật playlist thành công!");
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi: {ex.Message}");
            }
        }

        private void btnDeletePlaylist_Click(object sender, EventArgs e)
        {
            if (dgvPlaylists.SelectedRows.Count == 0)
            {
                UIHelper.ShowWarning("Vui lòng chọn playlist cần xóa!");
                return;
            }

            if (UIHelper.ShowDeleteConfirm("playlist"))
            {
                try
                {
                    int playlistID = Convert.ToInt32(dgvPlaylists.SelectedRows[0].Cells["PlaylistID"].Value);
                    bool success = PlaylistBUS.DeletePlaylist(playlistID);
                    
                    if (success)
                    {
                        UIHelper.ShowSuccess("Đã xóa playlist thành công!");
                        LoadPlaylists();
                        ClearForm();
                        dgvPlaylistSongs.DataSource = null;
                        currentPlaylistID = -1;
                    }
                }
                catch (Exception ex)
                {
                    UIHelper.ShowError($"Lỗi: {ex.Message}");
                }
            }
        }

        private void btnAddSongToPlaylist_Click(object sender, EventArgs e)
        {
            if (currentPlaylistID <= 0)
            {
                UIHelper.ShowWarning("Vui lòng chọn playlist trước!");
                return;
            }

            if (dgvAllSongs.SelectedRows.Count == 0)
            {
                UIHelper.ShowWarning("Vui lòng chọn bài hát cần thêm!");
                return;
            }

            try
            {
                int songID = Convert.ToInt32(dgvAllSongs.SelectedRows[0].Cells["SongID"].Value);
                bool success = PlaylistBUS.AddSongToPlaylist(currentPlaylistID, songID);
                
                if (success)
                {
                    UIHelper.ShowSuccess("Đã thêm bài hát vào playlist!");
                    LoadPlaylistSongs(currentPlaylistID);
                    LoadPlaylists();
                }
                else
                {
                    UIHelper.ShowWarning("Bài hát đã có trong playlist!");
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi: {ex.Message}");
            }
        }

        private void btnRemoveSongFromPlaylist_Click(object sender, EventArgs e)
        {
            if (currentPlaylistID <= 0)
            {
                UIHelper.ShowWarning("Vui lòng chọn playlist!");
                return;
            }

            if (dgvPlaylistSongs.SelectedRows.Count == 0)
            {
                UIHelper.ShowWarning("Vui lòng chọn bài hát cần xóa!");
                return;
            }

            try
            {
                int songID = Convert.ToInt32(dgvPlaylistSongs.SelectedRows[0].Cells["SongID"].Value);
                bool success = PlaylistBUS.RemoveSongFromPlaylist(currentPlaylistID, songID);
                
                if (success)
                {
                    UIHelper.ShowSuccess("Đã xóa bài hát khỏi playlist!");
                    LoadPlaylistSongs(currentPlaylistID);
                    LoadPlaylists();
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi: {ex.Message}");
            }
        }

        private void dgvPlaylists_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPlaylists.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dgvPlaylists.SelectedRows[0];
                    currentPlaylistID = Convert.ToInt32(row.Cells["PlaylistID"].Value);
                    
                    // Load chi tiết từ DB
                    Playlist selectedPlaylist = PlaylistBUS.GetPlaylistByID(currentPlaylistID);
                    if (selectedPlaylist != null)
                    {
                        txtPlaylistName.Text = selectedPlaylist.PlaylistName;
                        txtDescription.Text = selectedPlaylist.Description ?? "";
                        lblCurrentPlaylist.Text = $"Playlist hiện tại: {selectedPlaylist.PlaylistName}";
                    }
                    
                    LoadPlaylistSongs(currentPlaylistID);
                }
                catch { }
            }
        }

        private void txtSearchSong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearchSong.Text.Trim();
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    LoadAllSongs();
                }
                else
                {
                    songList = SongBUS.SearchSongs(searchTerm);
                    dgvAllSongs.DataSource = null;
                    dgvAllSongs.DataSource = songList;
                    ConfigureAllSongsDataGridView();
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi khi tìm kiếm: {ex.Message}");
            }
        }

        private void ClearForm()
        {
            txtPlaylistName.Clear();
            txtDescription.Clear();
            txtPlaylistName.Focus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPlaylists();
            LoadAllSongs();
            ClearForm();
        }

        /// <summary>
        /// Phát toàn bộ playlist
        /// </summary>
        private void btnPlayPlaylist_Click(object sender, EventArgs e)
        {
            if (currentPlaylistID <= 0)
            {
                UIHelper.ShowWarning("Vui lòng chọn playlist để phát!");
                return;
            }

            if (playlistSongs == null || playlistSongs.Count == 0)
            {
                UIHelper.ShowWarning("Playlist này chưa có bài hát nào!");
                return;
            }

            try
            {
                // Set playlist và phát từ đầu
                PlaybackManager.SetPlaylist(playlistSongs, 0);
                
                Playlist selectedPlaylist = PlaylistBUS.GetPlaylistByID(currentPlaylistID);
                UIHelper.ShowSuccess($"Đang phát playlist: {selectedPlaylist.PlaylistName}\n" +
                                        $"Tổng số bài hát: {playlistSongs.Count}");
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi khi phát playlist: {ex.Message}");
            }
        }

        /// <summary>
        /// Double-click vào bài hát trong playlist để phát từ bài đó
        /// </summary>
        private void dgvPlaylistSongs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (playlistSongs == null || playlistSongs.Count == 0)
            {
                UIHelper.ShowWarning("Không có bài hát nào trong playlist!");
                return;
            }

            try
            {
                // Lấy index của bài hát được double-click
                int songIndex = e.RowIndex;
                
                // Set playlist và phát từ bài hát được chọn
                PlaybackManager.SetPlaylist(playlistSongs, songIndex);
                
                Song selectedSong = playlistSongs[songIndex];
                UIHelper.ShowSuccess($"Đang phát: {selectedSong.SongTitle}\n" +
                                        $"Vị trí: {songIndex + 1}/{playlistSongs.Count}");
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi khi phát nhạc: {ex.Message}");
            }
        }

        /// <summary>
        /// Double-click vào playlist để phát toàn bộ
        /// </summary>
        private void dgvPlaylists_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                // Lấy playlist được double-click
                int playlistID = Convert.ToInt32(dgvPlaylists.Rows[e.RowIndex].Cells["PlaylistID"].Value);
                List<Song> songs = PlaylistBUS.GetPlaylistSongs(playlistID);
                
                if (songs.Count == 0)
                {
                    UIHelper.ShowWarning("Playlist này chưa có bài hát nào!");
                    return;
                }
                
                // Set playlist và phát từ đầu
                PlaybackManager.SetPlaylist(songs, 0);
                
                Playlist playlist = PlaylistBUS.GetPlaylistByID(playlistID);
                UIHelper.ShowSuccess($"Đang phát playlist: {playlist.PlaylistName}\n" +
                                        $"Tổng số bài hát: {songs.Count}");
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi khi phát playlist: {ex.Message}");
            }
        }
    }
}

