using System.Collections.Generic; 

namespace MusicGroup
{
    public class Album
    {
        public List<Song> SongList { get; set; }

        public Album(List<Song> songs)
                {
        if (songs == null)
        {
        throw new ArgumentNullException("нулл отстой");
        }

        SongList = songs;
                }

    }

}
