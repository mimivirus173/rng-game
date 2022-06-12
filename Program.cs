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
                Console.Write("Write a number between 1 and 99: ", Console.ForegroundColor = ConsoleColor.White);
                string input = Console.ReadLine();

                // Check if inputted number is valid
                if (int.TryParse(input, out number)) {
                    if (number < 100 && number > 0) {
                        int roll = numGen.Next(1, 100);

                        if (roll > number) {
                            Console.WriteLine("You win!", Console.ForegroundColor = ConsoleColor.Green);

                            // Gain points
                            Console.WriteLine("You gain " + number + " points.", Console.ForegroundColor = ConsoleColor.White);
                            points += number;
                            
                            Console.WriteLine("Current score: " + points);
                            Console.WriteLine("-------------------------");
                        } else {
                            // Loss
                            Console.Clear();

                            Console.WriteLine("You lose!", Console.ForegroundColor = ConsoleColor.DarkRed);
                            Console.WriteLine("Final score: " + points);
                            Console.WriteLine("-------------------------", Console.ForegroundColor = ConsoleColor.White);
                            points = 0;
                            break;
                        }                    
                    } else {
                        Console.WriteLine("Invalid input!", Console.ForegroundColor = ConsoleColor.Red);
                    };
                } else {
                    Console.WriteLine("Invalid input!", Console.ForegroundColor = ConsoleColor.Red);
                }
            }
        }
    }
}
