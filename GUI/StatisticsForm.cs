using System;
using System.Data;
using System.Windows.Forms;
using Sunny.UI;
using MusicLibraryManager.BUS;
using MusicLibraryManager.Helpers;

namespace MusicLibraryManager.GUI
{
    public partial class StatisticsForm : UIForm
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            try
            {
                // Thống kê theo thể loại
                DataTable dtGenre = GenreBUS.GetStatsByGenre();
                dgvGenreStats.DataSource = dtGenre;
                ConfigureGenreStatsGrid();

                // Top bài hát
                var topSongs = SongBUS.GetTopPlayedSongs(20);
                dgvTopSongs.DataSource = topSongs;
                ConfigureTopSongsGrid();

                // Bài hát yêu thích
                var favoriteSongs = SongBUS.GetFavoriteSongs();
                dgvFavorites.DataSource = favoriteSongs;
                ConfigureFavoritesGrid();

                // Tổng quan
                var allSongs = SongBUS.GetAllSongs();
                lblTotalSongs.Text = $"Tổng số bài hát: {allSongs.Count}";
                lblFavoriteCount.Text = $"Bài hát yêu thích: {favoriteSongs.Count}";
                
                var allPlaylists = PlaylistBUS.GetAllPlaylists();
                lblPlaylistCount.Text = $"Số playlist: {allPlaylists.Count}";
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi khi tải thống kê: {ex.Message}");
            }
        }

        private void ConfigureGenreStatsGrid()
        {
            if (dgvGenreStats.Columns.Count == 0) return;
            
            dgvGenreStats.Columns["GenreName"].HeaderText = "Thể loại";
            dgvGenreStats.Columns["GenreName"].Width = 150;
            dgvGenreStats.Columns["SongCount"].HeaderText = "Số bài hát";
            dgvGenreStats.Columns["SongCount"].Width = 100;
            
            if (dgvGenreStats.Columns.Contains("TotalDuration"))
            {
                dgvGenreStats.Columns["TotalDuration"].HeaderText = "Tổng thời lượng (giây)";
                dgvGenreStats.Columns["TotalDuration"].Width = 150;
            }
            
            if (dgvGenreStats.Columns.Contains("AvgRating"))
            {
                dgvGenreStats.Columns["AvgRating"].HeaderText = "Đánh giá TB";
                dgvGenreStats.Columns["AvgRating"].Width = 100;
            }
        }

        private void ConfigureTopSongsGrid()
        {
            dgvTopSongs.Columns["SongTitle"].HeaderText = "Tên bài hát";
            dgvTopSongs.Columns["ArtistName"].HeaderText = "Ca sĩ";
            dgvTopSongs.Columns["PlayCount"].HeaderText = "Lượt phát";
            
            foreach (DataGridViewColumn col in dgvTopSongs.Columns)
            {
                if (col.Name != "SongTitle" && col.Name != "ArtistName" && col.Name != "PlayCount")
                {
                    col.Visible = false;
                }
            }
        }

        private void ConfigureFavoritesGrid()
        {
            dgvFavorites.Columns["SongTitle"].HeaderText = "Tên bài hát";
            dgvFavorites.Columns["ArtistName"].HeaderText = "Ca sĩ";
            dgvFavorites.Columns["GenreName"].HeaderText = "Thể loại";
            
            foreach (DataGridViewColumn col in dgvFavorites.Columns)
            {
                if (col.Name != "SongTitle" && col.Name != "ArtistName" && col.Name != "GenreName")
                {
                    col.Visible = false;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStatistics();
        }
    }
}

