namespace FacadePattern.classes
{
    public class Amplifier
    {
        public string Name { get; set; }
        public DvdPlayer Dvd { get; set; }

        public Amplifier(string name)
        {
            Name = name;
        }

        public string On()
        {
            return Name + " on\n";
        }

        public string Off()
        {
            return Name + " off\n";
        }

        public string SetStereoSound()
        {
            return Name + " stereo mode on\n";
        }

        public string SetSurroundSound()
        {
            return Name + " surround sound on (5 speakers, 1 sub)\n";
        }

        public string SetVolume(int level)
        {
            return Name + " volume set to " + level + "\n";
        }

        public string SetDvd(DvdPlayer dvd)
        {
            Dvd = dvd;
            return Name + " setting tuner to " + dvd.Name + "\n";
        }
    }
}
