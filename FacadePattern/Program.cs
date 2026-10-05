using FacadePattern.Facade;

namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            CdPlayer cdPlayer = new CdPlayer(amp);
            DvdPlayer dvdPlayer = new DvdPlayer(amp);
            PopcornPopper popcornPopper = new PopcornPopper();
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            Tuner tuner = new Tuner(amp);
            HomeTheatorFacade homeTheatorFacade = new HomeTheatorFacade(dvdPlayer, cdPlayer, screen, lights, projector, popcornPopper, amp);

            homeTheatorFacade.WatchMovie("Die Hard");
            homeTheatorFacade.EndMovie();
        }
    }
}