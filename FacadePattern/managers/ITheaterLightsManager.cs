namespace FacadePattern.managers
{
    public interface ITheaterLightsManager
    {
        string On();

        string Off();

        string Dim(int level);
    }
}
