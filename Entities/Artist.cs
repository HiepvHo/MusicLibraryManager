using System;

namespace MusicLibraryManager.Entities
{
    public class Artist
    {
        public int ArtistID { get; set; }
        public string ArtistName { get; set; }
        public string Biography { get; set; }
        public string Country { get; set; }
        public string ImagePath { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public Artist()
        {
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
        }

        public override string ToString()
        {
            return ArtistName;
        }
    }
}

