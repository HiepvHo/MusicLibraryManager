using System;
using System.IO;
using System.Windows.Forms;
using Sunny.UI;
using MusicLibraryManager.Entities;
using MusicLibraryManager.Helpers;
using MusicLibraryManager.BUS;

namespace MusicLibraryManager.GUI
{
    public partial class MusicPlayerControl : UserControl
    {
        private AxWMPLib.AxWindowsMediaPlayer wmpPlayer;
        private bool isPlaying = false;
        private bool isUserSeeking = false;
        private PlayerWindow playerWindow;

        public MusicPlayerControl()
        {
            InitializeComponent();
            InitializeMediaPlayer();
            SubscribeToPlaybackManager();
            UpdateRepeatButton();
            UpdateShuffleButton();
        }

        private void InitializeMediaPlayer()
        {
            // Tạo Windows Media Player ẩn (không hiển thị)
            wmpPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(wmpPlayer)).BeginInit();
            wmpPlayer.Enabled = true;
            wmpPlayer.Visible = false; // Ẩn player, chỉ dùng để phát âm thanh
            wmpPlayer.Size = new System.Drawing.Size(0, 0);
            this.Controls.Add(wmpPlayer);
            ((System.ComponentModel.ISupportInitialize)(wmpPlayer)).EndInit();

            // Subscribe to events
            wmpPlayer.PlayStateChange += WmpPlayer_PlayStateChange;
            wmpPlayer.PositionChange += WmpPlayer_PositionChange;

            // Set volume
            wmpPlayer.settings.volume = 50;
        }

        private void SubscribeToPlaybackManager()
        {
            PlaybackManager.OnSongChanged += (s, song) => LoadSong(song);
            PlaybackManager.OnShuffleModeChanged += (s, isShuffleOn) => UpdateShuffleButton();
            PlaybackManager.OnRepeatModeChanged += (s, mode) => UpdateRepeatButton();
        }

        /// <summary>
        /// Load và phát bài hát
        /// </summary>
        public void LoadSong(Song song)
        {
            if (song == null || string.IsNullOrEmpty(song.FilePath))
            {
                UIHelper.ShowWarning("Không tìm thấy file nhạc!");
                return;
            }

            if (!File.Exists(song.FilePath))
            {
                UIHelper.ShowWarning($"File không tồn tại: {song.FilePath}");
                return;
            }

            try
            {
                wmpPlayer.URL = song.FilePath;
                lblSongTitle.Text = song.SongTitle;
                lblArtist.Text = song.ArtistName ?? "Unknown Artist";
                
                // Update play count
                SongBUS.UpdatePlayCount(song.SongID);
                
                // Log play history
                try
                {
                    PlayHistoryBUS.AddPlayHistory(song.SongID);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error logging history: {ex.Message}");
                }
                
                Play();
                
                // Kiểm tra nếu là file video thì tự động mở PlayerWindow
                // Delay một chút để đảm bảo media đã load
                if (IsVideoFile(song.FilePath))
                {
                    System.Threading.Timer timer = null;
                    timer = new System.Threading.Timer((obj) =>
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            OpenPlayerWindow();
                        });
                        timer?.Dispose();
                    }, null, 500, System.Threading.Timeout.Infinite);
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"Lỗi khi phát nhạc: {ex.Message}");
            }
        }
        
        /// <summary>
        /// Kiểm tra file có phải video không
        /// </summary>
        private bool IsVideoFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath)) return false;
            
            string[] videoExtensions = { ".mp4", ".avi", ".wmv", ".mkv", ".mov" };
            string extension = Path.GetExtension(filePath).ToLower();
            return Array.Exists(videoExtensions, ext => ext == extension);
        }
        
        /// <summary>
        /// Mở PlayerWindow (helper method)
        /// </summary>
        private void OpenPlayerWindow()
        {
            if (playerWindow == null || playerWindow.IsDisposed)
            {
                playerWindow = new PlayerWindow(this);
                playerWindow.Show();
            }
            else if (!playerWindow.Visible)
            {
                playerWindow.Show();
            }
            else
            {
                // Window đang mở rồi, chỉ cần bring to front và refresh
                playerWindow.BringToFront();
                playerWindow.Activate();
            }
        }

        /// <summary>
        /// Phát nhạc
        /// </summary>
        public void Play()
        {
            wmpPlayer.Ctlcontrols.play();
            isPlaying = true;
            btnPlay.Symbol = 61516; // Pause icon
            timerProgress.Start();
        }

        /// <summary>
        /// Tạm dừng
        /// </summary>
        public void Pause()
        {
            wmpPlayer.Ctlcontrols.pause();
            isPlaying = false;
            btnPlay.Symbol = 61764; // Play icon
            timerProgress.Stop();
        }

        /// <summary>
        /// Dừng
        /// </summary>
        public void Stop()
        {
            wmpPlayer.Ctlcontrols.stop();
            isPlaying = false;
            btnPlay.Symbol = 61764; // Play icon
            timerProgress.Stop();
            trackProgress.Value = 0;
            lblCurrentTime.Text = "00:00";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (PlaybackManager.CurrentSong == null)
            {
                UIHelper.ShowWarning("Chưa có bài hát nào được chọn!");
                return;
            }

            if (isPlaying)
                Pause();
            else
                Play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Song nextSong = PlaybackManager.Next();
            if (nextSong != null)
            {
                LoadSong(nextSong);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Song prevSong = PlaybackManager.Previous();
            if (prevSong != null)
            {
                LoadSong(prevSong);
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            PlaybackManager.ToggleShuffle();
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            PlaybackManager.ToggleRepeat();
        }

        private void trackVolume_ValueChanged(object sender, EventArgs e)
        {
            wmpPlayer.settings.volume = trackVolume.Value;
            lblVolume.Text = $"{trackVolume.Value}%";
        }

        private void trackProgress_MouseDown(object sender, MouseEventArgs e)
        {
            isUserSeeking = true;
        }

        private void trackProgress_MouseUp(object sender, MouseEventArgs e)
        {
            if (wmpPlayer.currentMedia != null)
            {
                double duration = wmpPlayer.currentMedia.duration;
                double newPosition = (trackProgress.Value / 100.0) * duration;
                wmpPlayer.Ctlcontrols.currentPosition = newPosition;
            }
            isUserSeeking = false;
        }

        private void trackProgress_ValueChanged(object sender, EventArgs e)
        {
            // ValueChanged được trigger bởi cả user và timer
            // Chỉ tua khi user đang kéo (MouseDown)
            if (isUserSeeking && wmpPlayer.currentMedia != null)
            {
                double duration = wmpPlayer.currentMedia.duration;
                double newPosition = (trackProgress.Value / 100.0) * duration;
                wmpPlayer.Ctlcontrols.currentPosition = newPosition;
            }
        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            if (wmpPlayer.currentMedia != null && !isUserSeeking)
            {
                double currentPos = wmpPlayer.Ctlcontrols.currentPosition;
                double duration = wmpPlayer.currentMedia.duration;

                if (duration > 0)
                {
                    trackProgress.Value = (int)((currentPos / duration) * 100);
                }

                lblCurrentTime.Text = TimeSpan.FromSeconds(currentPos).ToString(@"mm\:ss");
                lblDuration.Text = TimeSpan.FromSeconds(duration).ToString(@"mm\:ss");
            }
        }

        private void WmpPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // 1 = Stopped, 2 = Paused, 3 = Playing, 8 = MediaEnded
            if (e.newState == 8) // MediaEnded
            {
                // Tự động chuyển bài tiếp theo
                Song nextSong = PlaybackManager.Next();
                if (nextSong != null)
                {
                    LoadSong(nextSong);
                }
                else
                {
                    Stop();
                }
            }
            else if (e.newState == 3) // Playing
            {
                isPlaying = true;
                btnPlay.Symbol = 61516; // Pause icon
            }
            else if (e.newState == 2 || e.newState == 1) // Paused or Stopped
            {
                isPlaying = false;
                btnPlay.Symbol = 61764; // Play icon
            }
        }

        private void WmpPlayer_PositionChange(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e)
        {
            // Có thể dùng để sync với UI nếu cần
        }

        private void btnOpenPlayer_Click(object sender, EventArgs e)
        {
            OpenPlayerWindow();
        }

        private void UpdateShuffleButton()
        {
            if (PlaybackManager.IsShuffleMode)
            {
                btnShuffle.FillColor = System.Drawing.Color.FromArgb(80, 160, 255);
                btnShuffle.FillColor2 = System.Drawing.Color.FromArgb(80, 160, 255);
            }
            else
            {
                btnShuffle.FillColor = System.Drawing.Color.FromArgb(80, 126, 164);
                btnShuffle.FillColor2 = System.Drawing.Color.FromArgb(80, 126, 164);
            }
        }

        private void UpdateRepeatButton()
        {
            switch (PlaybackManager.CurrentRepeatMode)
            {
                case RepeatMode.None:
                    btnRepeat.Symbol = 61467; // Repeat icon
                    btnRepeat.FillColor = System.Drawing.Color.FromArgb(80, 126, 164);
                    btnRepeat.FillColor2 = System.Drawing.Color.FromArgb(80, 126, 164);
                    btnRepeat.SymbolSize = 24;
                    break;
                case RepeatMode.All:
                    btnRepeat.Symbol = 61467; // Repeat icon
                    btnRepeat.FillColor = System.Drawing.Color.FromArgb(80, 160, 255);
                    btnRepeat.FillColor2 = System.Drawing.Color.FromArgb(80, 160, 255);
                    btnRepeat.SymbolSize = 24;
                    break;
                case RepeatMode.One:
                    btnRepeat.Symbol = 61467; // Repeat One icon
                    btnRepeat.FillColor = System.Drawing.Color.FromArgb(80, 160, 255);
                    btnRepeat.FillColor2 = System.Drawing.Color.FromArgb(80, 160, 255);
                    btnRepeat.SymbolSize = 24;
                    break;
            }
        }

        /// <summary>
        /// Lấy Windows Media Player (để PlayerWindow sử dụng)
        /// </summary>
        public AxWMPLib.AxWindowsMediaPlayer GetMediaPlayer()
        {
            return wmpPlayer;
        }

        /// <summary>
        /// Check xem đang phát hay không
        /// </summary>
        public bool IsPlaying()
        {
            return isPlaying;
        }
    }
}

