using System;

namespace MusicGroup
{
    public class Song
    {
        public string Name { get; }
        public TimeSpan Duration { get; }

        public Song (string name, TimeSpan duration)
        {
            Name = name;
            Duration = duration;
        }
    }
}