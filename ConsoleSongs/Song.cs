using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSongs
{
    abstract class Song
    {
        public List<Note> notes;
        public abstract void Build();
        public abstract void Play();
    }
}
