using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Roulette
{
    class Program
    {
        public static int[] Roulnum = new int[] {00, 0, 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36, 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
        public static Random random = new Random();
        public static int bet = 0;
        static void Main()
        {
            Console.WriteLine(
                "Press 1 to bet \n" +
                "press 2 to quit");
            int response = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (response == 1)
                newBet();
            if (response == 2)
                System.Environment.Exit(0);
            else
                Main();
        }

        private static void newBet()
        {
            bet = random.Next(0, Roulnum.Length - 1);
            string rcolor = Rmechanics.getColor(bet);
            Console.WriteLine($"number is {bet}");
            Console.WriteLine("Winning bets would be: ");
            Console.WriteLine($"The number {bet}");
            string evenodd = Rmechanics.getEvenOdd(bet);
            Console.WriteLine(evenodd);
            Console.WriteLine(rcolor);
            string lowhigh = Rmechanics.getLowhigh(bet);
            Console.WriteLine(lowhigh);
            string dozens = Rmechanics.getDozens(bet);
            Console.WriteLine(dozens);
            string col = Rmechanics.getColumns(bet);
            Console.WriteLine(col);
            int[] street = Rmechanics.getStreet(bet);
            Console.Write($"street: ");
            foreach (int thing in street)
                Console.Write($"{thing}, ");
            Console.WriteLine();
            int[] dstreet = Rmechanics.getDstreet(bet);
            Console.Write($"double row: ");
            foreach (int thing in dstreet)
                Console.Write($"{thing}, ");
            Console.WriteLine();
            int[] split = Rmechanics.getSplit(bet, Roulnum);
            Console.Write("splits: ");
            foreach (int doohickey in split)
                Console.Write($"{doohickey}, ");
            Console.WriteLine();
            int[] corner = Rmechanics.getCorner(bet, Roulnum);

            Console.WriteLine();
            Main();
        }
    }
}
