namespace FacadePattern.managers
{
    public class DvdPlayerManager : IDvdPlayerManager
    {
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
