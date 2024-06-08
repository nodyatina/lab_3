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
            if (albums == null)
            {
                throw new ArgumentNullException("не может быть нулл 0_0");
            }

                Albums = albums;
        }
            
        }

        public void PrintTotalDuration()
        {
            if (Albums == null)
            {
                Console.WriteLine("No albums available to calculate total duration");
                return;
            }

            var totalDuration = Albums.SelectMany(album => album.SongList) // преобразование коллекции в одну последовательность
                         .Sum(song => song.Duration); // ямбда-выражение суммировать значение Duration для каждой песни

            Console.WriteLine($"Total duration of all songs: {totalDuration}");

        }
    }
