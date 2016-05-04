using FacadePattern.models;

namespace FacadePattern.managers
{
    public interface IAmplifierManager
    {
        string On(string name);
        string Off(string name);
        string SetStereoSound(string name);
        string SetSurroundSound(string name);
        string SetVolume(string name, int level);
        string SetDvd(Amplifier amp);
    }
}
