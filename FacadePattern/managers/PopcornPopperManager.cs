namespace FacadePattern.managers
{
    public class PopcornPopperManager
    {
        public static string On(string name)
        {
            return name + " on\n";
        }

        public string Off(string name)
        {
            return name + " off\n";
        }

        public string Pop(string name)
        {
            return name + " popping popcorn!\n";
        }
    }
}
