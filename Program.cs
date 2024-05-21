using MusicGroup;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        var song1 = new Song("Song One", new TimeSpan(0, 2, 30)); // создание экземпляров
        var song2 = new Song("Song Two", new TimeSpan(0, 3, 45));
        var song3 = new Song("Song Three", new TimeSpan(0, 5, 20));


        var album = new Album(new List<Song> { song1, song2, song3 });

        var studio = new Studio<Album>(new List<Album> { album });

        studio.PrintTotalDuration(); // вычисляю длительность треков
        Console.ReadKey();
    }
    

}