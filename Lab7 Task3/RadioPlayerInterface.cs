using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_Task3
{
    interface RadioPlayerInterface
    {
        void Switch(bool on);
        void retune(double frequency);
        void SetVolume(int loudness);
        void changeChannel();
    }
}
