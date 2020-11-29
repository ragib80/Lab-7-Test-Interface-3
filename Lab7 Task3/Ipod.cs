using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_Task3
{
    class Ipod : MusicFile, MusicPlayerInterface
    {

        private MusicFile[] musicFiles;

        public void changeChannel()
        {
            Console.WriteLine("Changing the current  Radio Channel................ \n");
        }

        public void play(bool on)
        {
            switch (on)
            {
                case true:
                    Console.WriteLine("Ipod is playing music \n");
                    break;
                case false:
                    Console.WriteLine("Ipod is off , not playing music \n");
                    break;

            }
        }

       
        public void retune(double frequency)
        {
            Console.WriteLine("The Radio Player tunning to  Frequency  : " + frequency+" Mhz \n");
        }

       
        public void SetVolume(int loudness)
        {
            Console.WriteLine("Volume is set to : " + loudness + " %");
        }

        public void Switch(bool on)
        {
            switch (on)
            {
                case true:
                    Console.WriteLine("Player is switch is on \n");
                    break;

                case false:
                    Console.WriteLine("Plaer is switch is off \n");
                    break;

            }
        }
        private int musicCount;
        public int MusicCount
        {
            get { return musicCount; }
            set { musicCount = value; }
        }

        public Ipod()
        {
            musicCount = 0;
            musicFiles = new MusicFile[500];
           
        }
        public Ipod(string title, string artist, int yearOfRelease, int durationInSeconds) : base(title, artist, yearOfRelease, durationInSeconds)
        {
            musicCount = 0;
            musicFiles = new MusicFile[500];
        }

        public void AddMusicFile(params MusicFile[] musicFiles)
        {
            foreach (var m in musicFiles)
            {
                Console.WriteLine(" ");
                if (musicCount < 500)
                {
                   this.musicFiles[musicCount++] = m;
                  
                }
               
                else
                {
                    Console.WriteLine("Cannot add more musicfiles :( , memory is full!  ");
                }
            }
        }
        
       
        public void playNext()
        {
            Console.WriteLine("\nNext Music is : ");
            
            for (int i = 1; i < musicCount; i++)
            {
                this.musicFiles[i++].ShowInfo();
                break;
            }
        }


        public void playPrevious()
        {
            Console.WriteLine("Previous Music is : ");
            for (int i = 0; i < musicCount; i++)
            {
                this.musicFiles[i--].ShowInfo();
                break;
            }
        }

        public void ShowAllMusicFile()
        {
            for (int i = 0; i < musicCount; i++)
            {
                this.musicFiles[i].ShowInfo();

            }
        }
    }
}
