using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_Task3
{
    interface MusicPlayerInterface : RadioPlayerInterface
    {
         
        void play(bool on);
        void playNext();
        void playPrevious();
    }
}
