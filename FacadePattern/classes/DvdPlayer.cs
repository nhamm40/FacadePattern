namespace FacadePattern.classes
{
    public class DvdPlayer
    {
        public string Name { get; set; }
        public Amplifier Amp { get; set; }
        public string Movie { get; set; }

        public DvdPlayer(string name, Amplifier amp)
        {
            Name = name;
            Amp = amp;
        }

        public string On()
        {
            return Name + " on.\n";
        }

        public string Off()
        {
            return Name + " off.\n";
        }

        public string Play(string movie)
        {
            Movie = movie;
            return Name + " playing " + movie + ".\n";
        }

        public string Stop()
        {
            return Name + " stopping.\n";
        }

        public string Eject()
        {
            return Name + " ejecting disc.\n";
        }
    }
}
