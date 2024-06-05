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
            Albums = albums ?? throw new ArgumentNullException(nameof(albums), "List of albums cannot be null");
        }

        public void PrintTotalDuration()
        {
            if (Albums == null)
            {
                Console.WriteLine("No albums available to calculate total duration");
                return;
            }

            var totalDuration = Albums.SelectMany(album => album.SongList)
                                      .Aggregate(TimeSpan.Zero, (subtotal, song) => subtotal + song.Duration);
            Console.WriteLine($"Total duration of all songs: {totalDuration}");
        }
    }
