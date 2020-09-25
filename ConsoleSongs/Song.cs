using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSongs
{
    abstract class Song
    {
        public List<Note> notes = new List<Note>();
        public abstract void Build();
        public void Play()
        {
            foreach (Note note in this.notes)
            {
                note.PlayNote();
            }
        }
    }
}
