using System;

namespace MusicLibraryManager.Entities
{
    public class Song
    {
        public int SongID { get; set; }
        public string SongTitle { get; set; }
        public int? ArtistID { get; set; }
        public int? AlbumID { get; set; }
        public int? GenreID { get; set; }
        public int? Duration { get; set; } // Giây
        public string FilePath { get; set; }
        public int? ReleaseYear { get; set; }
        public string Lyrics { get; set; }
        public int PlayCount { get; set; }
        public bool IsFavorite { get; set; }
        public int? Rating { get; set; } // 0-5
        public long? FileSize { get; set; } // Bytes
        public int? BitRate { get; set; } // kbps
        public DateTime CreatedDate { get; set; }
        public DateTime? LastPlayedDate { get; set; }

        // Navigation properties
        public string ArtistName { get; set; }
        public string AlbumName { get; set; }
        public string GenreName { get; set; }

        // Computed properties
        public string DurationFormatted
        {
            get
            {
                if (!Duration.HasValue) return "00:00";
                int minutes = Duration.Value / 60;
                int seconds = Duration.Value % 60;
                return $"{minutes:D2}:{seconds:D2}";
            }
        }

        public string FileSizeFormatted
        {
            get
            {
                if (!FileSize.HasValue) return "0 MB";
                double mb = FileSize.Value / (1024.0 * 1024.0);
                return $"{mb:F2} MB";
            }
        }

        public Song()
        {
            PlayCount = 0;
            IsFavorite = false;
            CreatedDate = DateTime.Now;
        }
    }
}

