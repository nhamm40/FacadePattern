
namespace FacadePattern.classes
{
    public class PopcornPopper
    {
        public string Name { get; set; }

        public PopcornPopper(string name)
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

        public string Pop()
        {
            return Name + " popping popcorn!\n";
        }
    }
}
