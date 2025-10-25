using System;

namespace MusicLibraryManager.Entities
{
    public class Playlist
    {
        public int PlaylistID { get; set; }
        public string PlaylistName { get; set; }
        public string Description { get; set; }
        public string CoverImagePath { get; set; }
        public bool IsPublic { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int SongCount { get; set; }

        public Playlist()
        {
            IsPublic = false;
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            SongCount = 0;
        }

        public override string ToString()
        {
            return PlaylistName;
        }
    }
}

