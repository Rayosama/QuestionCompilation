using System;

namespace BuildingAMadlibsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Building a mad libs game
            Console.WriteLine("Example of a Mad Libs game: ");
            Console.WriteLine(" ");

            string color, pluralNoun, celebrity;

            Console.Write("Enter a color:");
            color = Console.ReadLine();

            Console.Write("Enter a Plural Noun:");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a Celebrities name:");
            celebrity = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + "are Blue");
            Console.WriteLine("And I love" + celebrity);
            Console.WriteLine(" ");
        }
    }
}
