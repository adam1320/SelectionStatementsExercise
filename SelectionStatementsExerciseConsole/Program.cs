using System;

namespace SelectionStatementsExerciseConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var favoriteNumber = 7;

            Console.WriteLine("Try to guess my favorite number. Pick a number between 1 and 10");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput > favoriteNumber) 
            {
                Console.WriteLine("Too high! Better luck next time!");
            }
            else if (userInput < favoriteNumber) 
            {
                Console.WriteLine("Too low! Better luck next time!");
            }
            else if (userInput == favoriteNumber) 
            {
                Console.WriteLine("You are correct! Lucky guess!");
            }
            else
            {
                Console.WriteLine("Nevermind.");
            }
            

            


        }
    }
}
