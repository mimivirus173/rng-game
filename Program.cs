using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rngGame
{
    internal class Program
    {
        public static void Main(string[] args)
        {   
            // Console editing
            Console.Title = "RNG Game";

            // Main
            while (true)
            {
                RollNum();
            }
        }

        public static void RollNum()
        {
            // Random number generator
            Random numGen = new Random();
            
            // Variables
            int points = 0;
            int number;
            
            // Main
            while (true)
            {
                // Prompt the user
                Console.Write("Write a number between 1 and 99: ");
                number = Convert.ToInt32(Console.ReadLine());

                // Check if inputted number is valid
                if (number < 100 && number > 0) {
                    Console.WriteLine("You chose: " + number);

                    int roll = numGen.Next();

                    if (roll < number / 100) {
                        Console.WriteLine("You gain " + number + " points.");
                        points += number;
                        Console.WriteLine("Current points: " + points);
                    } else {
                        Console.WriteLine("You lose!");
                        break;
                    }
                    
                } else {
                    Console.WriteLine("Invalid input!");
                };
            }
        }
    }
}
