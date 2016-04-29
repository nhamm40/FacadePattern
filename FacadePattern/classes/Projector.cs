namespace FacadePattern.classes
{
    public class Projector
    {
        public string Name { get; set; }
        public DvdPlayer DvdPlayer { get; set; }

        public Projector(string name, DvdPlayer dvdPlayer)
        {
            Name = name;
            DvdPlayer = dvdPlayer;
        }

        public string On()
        {
            return Name + " on\n";
        }

        public string Off()
        {
            return Name + " off\n";
        }

        public string WideScreenMode()
        {
            return Name + " is in widescreen mode (16x9 aspect ratio)\n";
        }
    }
}
