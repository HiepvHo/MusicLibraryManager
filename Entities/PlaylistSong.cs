using System;

namespace MusicLibraryManager.Entities
{
    public class PlaylistSong
    {
        public int PlaylistSongID { get; set; }
        public int PlaylistID { get; set; }
        public int SongID { get; set; }
        public int OrderIndex { get; set; }
        public DateTime AddedDate { get; set; }

        public PlaylistSong()
        {
            AddedDate = DateTime.Now;
        }
    }
}

