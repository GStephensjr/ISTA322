using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisection_Algorith_Player_vs_Cpu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("guess my number between 1 and 100:");
            Random random = new Random();
            int answer = random.Next(0, 100);
            int acc = 0;
            guessCheck(answer, acc);
        }

        private static void guessCheck(int answer, int acc)
        {
            acc++;
            int guess = int.Parse(Console.ReadLine());
            if(guess < answer)
            {
                Console.WriteLine("Too Low");
                guessCheck(answer, acc);
            }
            else if (guess > answer)
            {
                Console.WriteLine("Too High");
                guessCheck(answer, acc);
            }
            else
            {
                Console.WriteLine("You Win");
                Console.WriteLine($"It took {acc} guesses");

            }
        }
    }
}
