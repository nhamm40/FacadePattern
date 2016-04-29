namespace FacadePattern.classes
{
    public class TheaterLights
    {
        private string Name { get; }

        public TheaterLights(string name)
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

        public string Dim(int level)
        {
            return Name + " dimming to " + level + "%\n";
        }
    }
}
