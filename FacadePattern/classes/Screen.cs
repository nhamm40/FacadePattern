namespace FacadePattern.classes
{
    public class Screen
    {
        public string Name { get; set; }

        public Screen(string name)
        {
            Name = name;
        }

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
