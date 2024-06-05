using System.Collections.Generic; 

namespace MusicGroup
{
    public class Album
    {
        public List<Song> SongList { get; set; }

        public Album(List<Song> songs)
        {
            SongList = songs ?? throw new ArgumentNullException(nameof(songs), "List of songs in the album cannot be null");
        }
    }

}
