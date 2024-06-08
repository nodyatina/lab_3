using System.Collections.Generic; 

namespace MusicGroup
{
    public class Album
    {public class Album
{
    public List<Song> SongList { get; set; }

    public Album(List<Song> songs)
    {
        if (songs == null)
        {
            throw new ArgumentNullException("нулл отстой");
        }

        foreach (Song song in songs)
        {
            if (song == null)
            {
                throw new ArgumentException("Один из элементов списка Song равен null");
            }
        }

        SongList = songs;
    }
}
    }

}
