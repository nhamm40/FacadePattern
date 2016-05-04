namespace FacadePattern.managers
{
    public interface IDvdPlayerManager
    {
        string On();
        string Off();
        string Play(string movie);
        string Stop();
        string Eject();
    }
}
