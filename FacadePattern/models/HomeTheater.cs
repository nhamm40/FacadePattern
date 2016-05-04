namespace FacadePattern.models
{
    public class HomeTheater
    {
        public Amplifier Amp { get; set; }
        public DvdPlayer Dvd { get; set; }
        public Projector Projector { get; set; }
        public TheaterLights Lights { get; set; }
        public Screen Screen { get; set; }
        public PopcornPopper Popper { get; set; }
    }
}
