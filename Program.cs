using System;
using System.Collections.Generic;

namespace pointGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numGen = new Random();
            
            // Variables
            int points = 0;
            int number;

            // Game
            Console.Write("Write a number between 1 and 99: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number > 99) {
                Console.WriteLine("Invalid number!");
                return;
            }
            Console.WriteLine("You chose: " + number);
            int roll = numGen.Next(1,100);
            Console.WriteLine("Computer chose: " + roll);

            if (roll == number) {
                Console.WriteLine("Computer picked the same number as you!");
                Console.WriteLine("You lose " + roll + " points.");
                points -= roll;
                return;
            } else {
            Console.WriteLine("You gain " + number + " points.");
            points += number;
            Console.WriteLine("Points: " + points);
            }
        
            // Wait before closing
            Console.ReadKey();
        }
    }
}