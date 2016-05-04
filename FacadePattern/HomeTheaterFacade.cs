using System;
using System.Text;
using FacadePattern.managers;
using FacadePattern.models;

namespace FacadePattern
{
    public class HomeTheaterFacade
    {
        private readonly IAmplifierManager _amplifierManager;
        private readonly IDvdPlayerManager _dvdPlayerManager;
        private readonly IProjectorManager _projectorManager;
        private readonly ITheaterLightsManager _theaterLightsManager;
        private readonly IScreenManager _screenManager;
        private readonly IPopcornPopperManager _popcornPopperManager;

        public HomeTheaterFacade(IAmplifierManager amplifierManager, IDvdPlayerManager dvdPlayerManager, IProjectorManager projectorManager, ITheaterLightsManager theaterLightsManager, IScreenManager screenManager, IPopcornPopperManager popcornPopperManager)
        {
            if (amplifierManager == null) throw new ArgumentException("amplifierManager");
            if (dvdPlayerManager == null) throw new ArgumentException("dvdPlayerManager");
            if (projectorManager == null) throw new ArgumentException("projectorManager");
            if (theaterLightsManager == null) throw new ArgumentException("theaterLightsManager");
            if (screenManager == null) throw new ArgumentException("screenManager");
            if (popcornPopperManager == null) throw new ArgumentException("popcornPopperManager");

            _amplifierManager = amplifierManager;
            _dvdPlayerManager = dvdPlayerManager;
            _projectorManager = projectorManager;
            _theaterLightsManager = theaterLightsManager;
            _screenManager = screenManager;
            _popcornPopperManager = popcornPopperManager;
        }

        private static readonly Amplifier Amp = new Amplifier
        {
            Name = "Denon Amplifier",
            Dvd = Dvd
        };

        private static readonly DvdPlayer Dvd = new DvdPlayer
        {
            Amp = Amp,
            Movie = "Fifth Element",
            Name = "Blu Ray Player"
        };
        readonly Projector projector = new Projector
        {
            DvdPlayer = Dvd,
            Name = "Epson Projector"
        };
        readonly TheaterLights lights = new TheaterLights
        {
            Name = "Rad Lights"
        };
        readonly Screen screen = new Screen("Silver Ticket 100 Movie Screen");
        readonly PopcornPopper popper = new PopcornPopper("Pop Pop!");

        public object WatchMovie(string movie)
        {
            var watchMovie = new StringBuilder();

            watchMovie.Append("Get ready to watch a movie...\n");
            watchMovie.Append(_popcornPopperManager.On());
            watchMovie.Append(_popcornPopperManager.Pop());
            watchMovie.Append(_theaterLightsManager.Dim(10));
            watchMovie.Append(_screenManager.Down());
            watchMovie.Append(_projectorManager.On());
            watchMovie.Append(_projectorManager.WideScreenMode());
            watchMovie.Append(_amplifierManager.On(Amp.Name));
            watchMovie.Append(_amplifierManager.SetDvd(Amp));
            watchMovie.Append(_amplifierManager.SetSurroundSound(Amp.Name));
            watchMovie.Append(_amplifierManager.SetVolume(Amp.Name, 15));
            watchMovie.Append(_dvdPlayerManager.On());
            watchMovie.Append(_dvdPlayerManager.Play(movie));
            return watchMovie.ToString();
        }
        public object EndMovie()
        {
            var endMovie = new StringBuilder();

            endMovie.Append("Shutting movie theater down...\n");
            endMovie.Append(_popcornPopperManager.Off());
            endMovie.Append(_theaterLightsManager.On());
            endMovie.Append(_screenManager.Up());
            endMovie.Append(_projectorManager.Off());
            endMovie.Append(_amplifierManager.Off(Amp.Name));
            endMovie.Append(_dvdPlayerManager.Stop());
            endMovie.Append(_dvdPlayerManager.Eject());
            endMovie.Append(_dvdPlayerManager.Off());

            return endMovie.ToString();
        }
    }
}
