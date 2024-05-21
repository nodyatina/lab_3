using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicGroup
{
    public class Studio<TAlbum> where TAlbum : Album
    {
        public List<TAlbum> Albums { get; set; }

        public Studio(List<TAlbum> albums)
        {
            Albums = albums;
        }

        public void PrintTotalDuration()
        {
            var totalDuration = Albums.SelectMany(album => album.SongList)
                                      .Aggregate(TimeSpan.Zero, (subtotal, song) => subtotal + song.Duration); 
            Console.WriteLine($"Total duration of all songs: {totalDuration}"); 
        }
    }
}
