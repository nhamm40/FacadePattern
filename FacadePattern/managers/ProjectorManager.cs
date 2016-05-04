namespace FacadePattern.managers
{
    public class ProjectorManager : IProjectorManager
    {
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
