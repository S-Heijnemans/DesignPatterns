using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Facade
{
    class HomeTheatorFacade
    {
        private DvdPlayer _dvdPlayer;
        private CdPlayer _cdPlayer;
        private Screen _screen;
        private TheaterLights _theaterLights;
        private Projector _projector;
        private PopcornPopper _popcornPopper;
        private Amplifier _amplifier;
        

        public HomeTheatorFacade(DvdPlayer dvdPlayer, CdPlayer cdPlayer, Screen screen, TheaterLights theaterLights, Projector projector, PopcornPopper popcornPopper, Amplifier amplifier)
        {
            _dvdPlayer = dvdPlayer;
            _cdPlayer = cdPlayer;
            _screen = screen;
            _theaterLights = theaterLights;
            _projector = projector;
            _popcornPopper = popcornPopper;
            _amplifier = amplifier;
        }
        public void WatchMovie(string movie)
        {
            _popcornPopper.On();
            _popcornPopper.Pop();

            _theaterLights.Dim(10);

            _screen.Down();

            _projector.On();
            _projector.SetInput(_dvdPlayer);
            _projector.WideScreenMode();

            _amplifier.On();
            _amplifier.SetDvd(_dvdPlayer);
            _amplifier.SetSurroundSound();
            _amplifier.SetVolume(5);

            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            _popcornPopper.Off();

            _theaterLights.Off();

            _screen.Up();

            _projector.Off();

            _amplifier.Off();

            _dvdPlayer.Stop();
            _dvdPlayer.Eject();
            _dvdPlayer.Off();

        }

        public void ListenToCd()
        {

        }

        public void EndCd()
        {

        }

        public void ListenToRadio()
        {

        }

        public void EndRadio()
        {

        }
    }
}
