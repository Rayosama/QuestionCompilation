using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = ""; //Variable where their guess gets stored
            int guessCount = 0; //Keeps track of how many times they guess
            int guessLimit = 4; //Variable we use to set the limit for guesses
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses) //Keeps going while guess does not equal secret and not outofGuess
            {
                if (guessCount < guessLimit) //Firs thing we check in the loop 
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true; 
                }
                 
            }
            if(outOfGuesses)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.Write("You win!!");
                
            }


            Console.ReadLine();
        }
    }
}
