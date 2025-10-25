using System;

namespace MusicLibraryManager.Entities
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string GenreName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

        public Genre()
        {
            CreatedDate = DateTime.Now;
        }

        public override string ToString()
        {
            return GenreName;
        }
    }
}

