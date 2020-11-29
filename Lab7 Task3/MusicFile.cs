using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_Task3
{
    class MusicFile
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string artist;

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        private int yearOfRelease;

        public int YearOfRelease
        {
            get { return yearOfRelease; }
            set { yearOfRelease = value; }
        }

        private int durationInSeconds;

        public int DurationInSounds
        {
            get { return durationInSeconds; }
            set { durationInSeconds = value; }
        }


    public MusicFile()
        {

        }

        public MusicFile(string title, string artist, int yearOfRelease, int durationInSeconds)
        {
            this.title = title;
            this.artist = artist;
            this.yearOfRelease = yearOfRelease;
            this.durationInSeconds = durationInSeconds;
        }

        public void changeTitle(string title)
        {
           Console.WriteLine("Changing the title, new title is  : " + title);
        }

        public void ShowInfo()
        {
            Console.WriteLine("Music Title is : " + title);
            Console.WriteLine("Artist : " + artist);
            Console.WriteLine("Release Year : " + yearOfRelease);
            Console.WriteLine("Duration : " + durationInSeconds + " min");
            Console.WriteLine(" ");
        }

    }
}
