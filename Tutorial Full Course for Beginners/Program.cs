using System;

namespace Tutorial_Full_Course_for_Beginners
{
    class Program
    {
        //Guide to examples given throught the different solutions https://www.youtube.com/watch?v=GhQdlIFylQ8
        static void Main(string[] args)
        {
            //Data types
            Console.WriteLine("Data type examples");
            string phrase = "Giraffe Academy";
            char grade = 'A';
            int age = 30;
            
            //float, double, decimal Used to store decimals, goes from least accurate to most accurate
            bool isMale = false; //Or true. bool can only be true or false

            string phase = ("Giraffe Academy");
            Console.WriteLine(phase);

            Console.WriteLine(phrase.ToUpper()); //Takes phrase and makes it all upper case
            Console.WriteLine(phrase.Contains("aff"));
            Console.WriteLine(phrase.Substring(8, 7)); //This will grab a piece of the the string, starting at index 8. The 7 isn't needed, but tells the program how many chars to grab
            Console.WriteLine(" ");
            //Taking users input
            Console.WriteLine("Taking users input");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name);
            Console.WriteLine(" ");
            //Building a calculator
            Console.WriteLine("Calculator example: ");
            int num = Convert.ToInt32("45"); //Converting a string to an integer
            Console.WriteLine(num + 5);

            Console.Write("Enter your first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your total is: " + (num1 + num2));
            Console.WriteLine(" ");

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

            //Arrays
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            Console.WriteLine(luckyNumbers[]);

            Console.ReadLine();

        }
    }
}
