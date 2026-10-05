using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Amplifier
    {
        private Tuner _tuner;
        private DvdPlayer _dvdPlayer;
        private CdPlayer _cdPlayer;

        public void On()
        {
            Console.WriteLine("Amplifier turned on");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier turned off");
        }
        public void SetCd(CdPlayer cdPlayer)
        {
            this._cdPlayer = cdPlayer;
            Console.WriteLine("CD is set");
        }
        public void SetDvd(DvdPlayer dvdPlayer)
        {
            this._dvdPlayer = dvdPlayer;
            Console.WriteLine("DvD is set");
        }
        public void SetStereoSound()
        {
            Console.WriteLine("Stereo sound is set");
        }
        public void SetSurroundSound()
        {
            Console.WriteLine("Surround sound is set");
        }
        public void SetTuner(Tuner tuner)
        {
            this._tuner = tuner;
            Console.WriteLine("Turner is set");
        }
        public void SetVolume(int volume)
        {
            Console.WriteLine("Volume is set");
        }

    }
}
