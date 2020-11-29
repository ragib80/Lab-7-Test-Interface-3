using System;

namespace Lab7_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            RadioPlayerInterface i1 = new Ipod("See You Again", "Wiz Khalifa",2015,4);
            i1.Switch(true);
            i1.retune(89.6);
            i1.SetVolume(70);
            i1.changeChannel();
           

            MusicFile m1 = new MusicFile("oniket prantor", "Artcell",2006,16);
            MusicFile m2 = new MusicFile("dhusor somoy", "Artcell", 2006, 7);
            MusicFile m3 = new MusicFile("Anmone", "Arthohin", 2007, 5);
            Ipod i2 = new Ipod();
            i2.Switch(true);
            i2.play(true);
            i2.AddMusicFile(m1,m2,m3);
            i2.ShowAllMusicFile();
            i2.SetVolume(90);
           
            i2.playNext();
            Console.WriteLine(" ");
            i2.playPrevious();
           
        }
    }
}
