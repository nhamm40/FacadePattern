namespace FacadePattern.managers
{
    class ScreenManager : IScreenManager
    {
        public string Up()
        {
            return Name + " going up\n";
        }

        public string Down()
        {
            return Name + " going down\n";
        }
    }
}
