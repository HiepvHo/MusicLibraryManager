using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Sunny.UI;
using MusicLibraryManager.BUS;
using MusicLibraryManager.Entities;
using MusicLibraryManager.Helpers;

namespace MusicLibraryManager.GUI
{
    public partial class HistoryForm : UIForm
    {
        private List<PlayHistory> historyList;
        
        public HistoryForm()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            // Set date filters to default values
            dtpFrom.Value = DateTime.Now.AddDays(-30);
            dtpTo.Value = DateTime.Now;
            
            LoadData();
            LoadStatistics();
        }

        private void LoadData()
        {
            try
            {
                // Lấy lịch sử gần đây (top 100)
                historyList = PlayHistoryBUS.GetRecentlyPlayed(100);
                
                dgvHistory.DataSource = null;
                dgvHistory.DataSource = historyList;
                
                ConfigureDataGridView();
                
                lblTotalRecords.Text = $"Tổng số: {historyList.Count} lượt phát";
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi khi tải lịch sử: {ex.Message}");
            }
        }

        private void ConfigureDataGridView()
        {
            dgvHistory.AutoGenerateColumns = false;
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.ReadOnly = true;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.MultiSelect = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            
            dgvHistory.Columns.Clear();
            
            // HistoryID (ẩn)
            dgvHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "HistoryID",
                DataPropertyName = "HistoryID",
                Visible = false
            });
            
            // SongID (ẩn)
            dgvHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SongID",
                DataPropertyName = "SongID",
                Visible = false
            });
            
            // Tên bài hát
            dgvHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SongTitle",
                DataPropertyName = "SongTitle",
                HeaderText = "Tên bài hát",
                Width = 250,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            
            // Ca sĩ
            dgvHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ArtistName",
                DataPropertyName = "ArtistName",
                HeaderText = "Ca sĩ",
                Width = 180
            });
            
            // Thể loại
            dgvHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "GenreName",
                DataPropertyName = "GenreName",
                HeaderText = "Thể loại",
                Width = 120
            });
            
            // Thời gian phát
            dgvHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PlayedDateFormatted",
                DataPropertyName = "PlayedDateFormatted",
                HeaderText = "Thời gian",
                Width = 150
            });
            
            // Device
            dgvHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DeviceName",
                DataPropertyName = "DeviceName",
                HeaderText = "Thiết bị",
                Width = 120
            });
        }

        private void LoadStatistics()
        {
            try
            {
                DataTable stats = PlayHistoryBUS.GetListeningStats();
                
                if (stats.Rows.Count > 0)
                {
                    DataRow row = stats.Rows[0];
                    
                    lblTotalPlays.Text = $"Tổng lượt phát: {row["TotalPlays"]}";
                    lblUniqueSongs.Text = $"Bài hát unique: {row["UniqueSongs"]}";
                    lblLast7Days.Text = $"7 ngày gần đây: {row["PlaysLast7Days"]} lượt";
                    lblLast30Days.Text = $"30 ngày gần đây: {row["PlaysLast30Days"]} lượt";
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error loading stats: {ex.Message}");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadStatistics();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromDate = dtpFrom.Value.Date;
                DateTime toDate = dtpTo.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
                
                if (fromDate > toDate)
                {
                    UIHelper.ShowWarning("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!");
                    return;
                }
                
                historyList = PlayHistoryBUS.GetPlayHistoryByDate(fromDate, toDate);
                dgvHistory.DataSource = null;
                dgvHistory.DataSource = historyList;
                ConfigureDataGridView();
                
                lblTotalRecords.Text = $"Tổng số: {historyList.Count} lượt phát";
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi khi lọc: {ex.Message}");
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (!UIHelper.ShowConfirm(
                "Bạn có chắc muốn xóa TOÀN BỘ lịch sử phát nhạc?\n\nThao tác này không thể hoàn tác!",
                "Xác nhận xóa lịch sử"))
            {
                return;
            }
            
            try
            {
                PlayHistoryBUS.ClearAllHistory();
                UIHelper.ShowSuccess("Đã xóa toàn bộ lịch sử!");
                LoadData();
                LoadStatistics();
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi khi xóa: {ex.Message}");
            }
        }

        private void btnClearOld_Click(object sender, EventArgs e)
        {
            // Show input dialog
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Xóa lịch sử cũ hơn bao nhiêu ngày?\n(Ví dụ: 30, 60, 90)",
                "Xóa lịch sử cũ",
                "30"
            );
            
            if (string.IsNullOrEmpty(input))
                return;
            
            if (!int.TryParse(input, out int days) || days <= 0)
            {
                UIHelper.ShowWarning("Vui lòng nhập số ngày hợp lệ (lớn hơn 0)!");
                return;
            }
            
            if (!UIHelper.ShowConfirm(
                $"Bạn có chắc muốn xóa lịch sử cũ hơn {days} ngày?",
                "Xác nhận xóa"))
            {
                return;
            }
            
            try
            {
                PlayHistoryBUS.ClearOldHistory(days);
                UIHelper.ShowSuccess($"Đã xóa lịch sử cũ hơn {days} ngày!");
                LoadData();
                LoadStatistics();
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi khi xóa: {ex.Message}");
            }
        }

        private void dgvHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            
            try
            {
                int songID = Convert.ToInt32(dgvHistory.Rows[e.RowIndex].Cells["SongID"].Value);
                Song song = SongBUS.GetSongByID(songID);
                
                if (song != null)
                {
                    // Trigger playback through PlaybackManager
                    PlaybackManager.PlaySong(song);
                    UIHelper.ShowSuccess($"Đang phát: {song.SongTitle}");
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi khi phát nhạc: {ex.Message}");
            }
        }

        private void dgvHistory_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = dgvHistory.HitTest(e.X, e.Y);
                if (hitTest.RowIndex >= 0)
                {
                    dgvHistory.ClearSelection();
                    dgvHistory.Rows[hitTest.RowIndex].Selected = true;
                    contextMenuHistory.Show(dgvHistory, e.Location);
                }
            }
        }

        private void menuPlaySong_Click(object sender, EventArgs e)
        {
            if (dgvHistory.SelectedRows.Count == 0)
                return;
            
            try
            {
                int songID = Convert.ToInt32(dgvHistory.SelectedRows[0].Cells["SongID"].Value);
                Song song = SongBUS.GetSongByID(songID);
                
                if (song != null)
                {
                    PlaybackManager.PlaySong(song);
                    UIHelper.ShowSuccess($"Đang phát: {song.SongTitle}");
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi: {ex.Message}");
            }
        }

        private void menuDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvHistory.SelectedRows.Count == 0)
                return;
            
            if (!UIHelper.ShowConfirm("Bạn có chắc muốn xóa item này khỏi lịch sử?"))
                return;
            
            try
            {
                int historyID = Convert.ToInt32(dgvHistory.SelectedRows[0].Cells["HistoryID"].Value);
                PlayHistoryBUS.DeleteHistoryItem(historyID);
                
                LoadData();
                LoadStatistics();
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi: {ex.Message}");
            }
        }

        private void btnMostPlayed_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable mostPlayed = PlayHistoryBUS.GetMostPlayedSongs(20);
                
                if (mostPlayed.Rows.Count == 0)
                {
                    UIHelper.ShowWarning("Chưa có dữ liệu!");
                    return;
                }
                
                // Show in a message box or separate form
                string message = "🏆 TOP 20 BÀI HÁT ĐƯỢC NGHE NHIỀU NHẤT:\n\n";
                int rank = 1;
                foreach (DataRow row in mostPlayed.Rows)
                {
                    message += $"{rank}. {row["SongTitle"]} - {row["ArtistName"]} ({row["PlayCount"]} lần)\n";
                    rank++;
                    if (rank > 10) break; // Chỉ hiện top 10 trong message
                }
                
                MessageBox.Show(message, "Top Bài Hát", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi: {ex.Message}");
            }
        }
    }
}

