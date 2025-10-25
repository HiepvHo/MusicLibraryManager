using System;

namespace MusicLibraryManager.Entities
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string AlbumName { get; set; }
        public int? ArtistID { get; set; }
        public int? ReleaseYear { get; set; }
        public string CoverImagePath { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

        // Navigation property
        public string ArtistName { get; set; }

        public Album()
        {
            CreatedDate = DateTime.Now;
        }

        public override string ToString()
        {
            return AlbumName;
        }
    }
}

