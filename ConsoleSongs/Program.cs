using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSongs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Press any key to Play");
            Console.ReadKey(true);
            HarderBetterFasterStrongerSong hbfss = new HarderBetterFasterStrongerSong();
            hbfss.Play();
        }
    }
}
