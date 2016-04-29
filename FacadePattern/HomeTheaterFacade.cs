using FacadePattern.classes;
using System.Text;

namespace FacadePattern
{
    public class HomeTheaterFacade
    {
        public Amplifier Amp { get; set; }
        public DvdPlayer Dvd { get; set; }
        public Projector Projector { get; set; }
        public TheaterLights Lights { get; set; }
        public Screen Screen { get; set; }
        public PopcornPopper Popper { get; set; }

        public HomeTheaterFacade(Amplifier amp, DvdPlayer dvd, Projector projector, TheaterLights lights, Screen screen, PopcornPopper popper)
        {
            Amp = amp;
            Dvd = dvd;
            Projector = projector;
            Screen = screen;
            Lights = lights;
            Popper = popper;
        }

        public object WatchMovie(string movie)
        {
            var watchMovie = new StringBuilder();

            watchMovie.Append("Get ready to watch a movie...\n");
            watchMovie.Append(Popper.On());
            watchMovie.Append(Popper.Pop());
            watchMovie.Append(Lights.Dim(10));
            watchMovie.Append(Screen.Down());
            watchMovie.Append(Projector.On());
            watchMovie.Append(Projector.WideScreenMode());
            watchMovie.Append(Amp.On());
            watchMovie.Append(Amp.SetDvd(Dvd));
            watchMovie.Append(Amp.SetSurroundSound());
            watchMovie.Append(Amp.SetVolume(15));
            watchMovie.Append(Dvd.On());
            watchMovie.Append(Dvd.Play(movie));
            return watchMovie.ToString();
        }
        public object EndMovie()
        {
            var endMovie = new StringBuilder();

            endMovie.Append("Shutting movie theater down...\n");
            endMovie.Append(Popper.Off());
            endMovie.Append(Lights.On());
            endMovie.Append(Screen.Up());
            endMovie.Append(Projector.Off());
            endMovie.Append(Amp.Off());
            endMovie.Append(Dvd.Stop());
            endMovie.Append(Dvd.Eject());
            endMovie.Append(Dvd.Off());

            return endMovie.ToString();
        }
    }
}
