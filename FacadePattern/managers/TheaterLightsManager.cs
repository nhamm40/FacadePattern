namespace FacadePattern.managers
{
    public class TheaterLightsManager : ITheaterLightsManager
    {
        public string On()
        {
            return Name + " on\n";
        }

        public string Off()
        {
            return Name + " off\n";
        }

        public string Dim(int level)
        {
            return Name + " dimming to " + level + "%\n";
        }
    }
}
