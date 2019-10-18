using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisection_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            begin();
        }

        private static void begin()
        {
            int guess = 50;
            int high = 101;
            int low = 0;
            int acc = 0;


            Console.WriteLine("pick a number between 1 and 100: ");
            Console.WriteLine("do you have your number? \n y/n");
            string response = Console.ReadLine();
            if (response == "y")
                game(guess, high, low, acc);
            else
                begin();
        }

        private static void game(int guess, int high, int low, int acc)
        {

            Console.WriteLine($"is {guess} too high, too low, or correct \n 1. too high, 2. too low, 3. correct");
            string response = Console.ReadLine();
            acc++;

            if (response == "3")
            {
                Console.WriteLine("I win");
                Console.WriteLine($"It took {acc} guesses");

            }


            else if (response == "1")
            {
                high = --guess;
                guess = (high + low) / 2;
                game(guess, high, low, acc);
            }
            else if (response == "2")
            {
                low = ++guess;
                guess = (low + high) / 2;
                game(guess, high, low, acc);
            }
            else
            {
                game(guess, high, low, acc);
            }
        }
    }
    }

