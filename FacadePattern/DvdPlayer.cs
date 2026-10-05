using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class DvdPlayer
    {
        private Amplifier _amplifier;
        public DvdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("DvD player turned on");
        }
        public void Off()
        {
            Console.WriteLine("DvD player turned off");
        }
        public void Eject()
        {
            Console.WriteLine("Eject DvD");
        }
        public void Pause()
        {
            Console.WriteLine("Pauze DvD");
        }
        public void Play(string movie)
        {
            Console.WriteLine("Play movie");
        }
        public void SetSurroundAudio()
        {
            Console.WriteLine("Surround sound is set");
        }
        public void SetTWoChannelAudio()
        {

        }
        public void Stop()
        {
            Console.WriteLine("Stop DvD");
        }
    }
}
