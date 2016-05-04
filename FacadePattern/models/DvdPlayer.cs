using FacadePattern.models;

namespace FacadePattern.models
{
    public class DvdPlayer
    {
        public string Name { get; set; }
        public Amplifier Amp { get; set; }
        public string Movie { get; set; }
    }
}
