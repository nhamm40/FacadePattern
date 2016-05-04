using FacadePattern.models;

namespace FacadePattern.managers
{
    public class AmplifierManager : IAmplifierManager
    {
        public string On(string name)
        {
            return name + " on\n";
        }

        public string Off(string name)
        {
            return name + " off\n";
        }

        public string SetStereoSound(string name)
        {
            return name + " stereo mode on\n";
        }

        public string SetSurroundSound(string name)
        {
            return name + " surround sound on (5 speakers, 1 sub)\n";
        }

        public string SetVolume(string name, int level)
        {
            return name + " volume set to " + level + "\n";
        }

        public string SetDvd(string name, DvdPlayer dvd)
        {
            return name + " setting tuner to " + dvd.Name + "\n";
        }
    }
}
