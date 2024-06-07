using System;

namespace MusicGroup
{
    public class Song
    {
        public string Name { get; }
        public TimeSpan Duration { get; }

        public Song(string name, TimeSpan duration)
        {
            if (name == null)
            {
                throw new ArgumentNullException("не может быть нулл -_-");
            }

            if (duration == null)
            {
                throw new ArgumentNullException( "не может быть нулл -_-");
            }

            Name = name;
            Duration = duration;
            }

    }
}
