using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSongs
{
    class Note
    {
        public const int C3 = 130;
        public const int D3 = 147;
        public const int DS3 = 155;
        public const int E3 = 164;
        public const int F3 = 174;
        public const int G3 = 196;
        public const int A3 = 220;
        public const int AS3 = 233;
        public const int B3 = 247;
        public const int C4 = 261;
        public const int D4 = 293;
        public const int DS4 = 311;
        public const int E4 = 329;
        public const int F4 = 349;
        public const int G4 = 392;
        public const int A4 = 440;
        public const int AS4 = 466;
        public const int B4 = 494;
        public const int C5 = 523;
        public const int D5 = 587;
        public const int DS5 = 622;
        public const int E5 = 659;
        public const int F5 = 698;
        public const int G5 = 784;
        public const int A5 = 880;
        public const int AS5 = 932;
        public const int B5 = 988;
        public const int C6 = 1046;
        public const int D6 = 1174;
        public const int DS6 = 1244;
        public const int E6 = 1568;
        public const int F6 = 1397;
        public const int G6 = 1568;
        public const int A6 = 1760;
        public const int AS6 = 1864;
        public const int B6 = 1975;
        public const int C7 = 2093;
        public const int D7 = 2349;
        public const int DS7 = 2489;
        public const int E7 = 2637;
        public const int F7 = 2793;
        public const int G7 = 3136;
        public const int A7 = 3520;
        public const int AS7 = 3729;
        public const int B7 = 3951;

        public void PlayNote()
        {
            if (duration != 0)
            {
                if (note == 0)
                {
                    // Silence.
                    System.Threading.Thread.Sleep(this.duration);
                }
                else
                {
                    // Play it.
                    Console.Beep(this.note, this.duration);
                }
            }
        }

        private int note;
        private int duration;

        public Note(int note, int duration)
        {
            if (note >= 0)
            {
                this.note = note;
            }
            else
            {
                this.note = 0;
            }
            if (duration > 0)
            {
                this.duration = duration;
            }
            else
            {
                this.duration = 0;
            }
        }
    }
}