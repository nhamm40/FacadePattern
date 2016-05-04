using System;
using FacadePattern.models;

namespace FacadePattern
{
    public class HomeTheaterTestDrive
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of a Movie you would like to watch: ");
            var movie = Console.ReadLine();

            var amp = new Amplifier("Denon Amplifier");
            var dvd = new DvdPlayer("Blu Ray Player", amp);
            var projector = new Projector("Epson Projector", dvd);
            var lights = new TheaterLights("Rad Lights");
            var screen = new Screen("Silver Ticket 100 Movie Screen");
            var popper = new PopcornPopper("Pop Pop!");

            var homeTheater = new HomeTheaterFacade(amp, dvd, projector, lights, screen, popper);

            Console.WriteLine(homeTheater.WatchMovie(movie));
            Console.WriteLine("Please press Enter when movie has ended.");
            Console.ReadKey();
            Console.WriteLine(homeTheater.EndMovie());

            Console.ReadKey();
        }
    }
}
