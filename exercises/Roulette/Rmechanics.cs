using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Rmechanics
    {
        public static int[] getCorner(int bet, int[] Roulnum)
        {
            int[] rnum = Roulnum;
            Array.Sort(rnum);



            return rnum;
        }

        public static int[] getSplit(int bet, int[] roulnum)
        {
            int[] rnum = roulnum;
            Array.Sort(rnum);
            int[] compare = new int[5];
            if (bet > 3)
                compare[0] = rnum[bet - 3];
            if (bet > 1)
                compare[1] = rnum[bet - 1];
            compare[2] = rnum[bet];
            if (bet < 36)
                compare[3] = rnum[bet + 1];
            if (bet < 34)
                compare[4] = rnum[bet + 3];
            return compare;
        }

        public static int[] getDstreet(int bet)
        {
            int[] dstreet1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] dstreet2 = new int[] { 7, 8, 9, 10, 11, 12 };
            int[] dstreet3 = new int[] { 13, 14, 15, 16, 17, 18 };
            int[] dstreet4 = new int[] { 19, 20, 21, 22, 23, 24 };
            int[] dstreet5 = new int[] { 25, 26, 27, 28, 29, 30 };
            int[] dstreet6 = new int[] { 31, 32, 33, 34, 35, 36 };

            int[] result = new int[] { };
            if (dstreet1.Contains(bet))
                result = dstreet1;
            else if (dstreet2.Contains(bet))
                result = dstreet2;
            else if (dstreet3.Contains(bet))
                result = dstreet3;
            else if (dstreet4.Contains(bet))
                result = dstreet4;
            else if (dstreet5.Contains(bet))
                result = dstreet5;
            else if (dstreet6.Contains(bet))
                result = dstreet6;
            return result;
        }

        public static int[] getStreet(int bet)
        {
            int[] street1 = new int[] { 1, 2, 3 };
            int[] street2 = new int[] { 4, 5, 6 };
            int[] street3 = new int[] { 7, 8, 9 };
            int[] street4 = new int[] { 10, 11, 12 };
            int[] street5 = new int[] { 13, 14, 15 };
            int[] street6 = new int[] { 16, 17, 18 };
            int[] street7 = new int[] { 19, 20, 21 };
            int[] street8 = new int[] { 22, 23, 24 };
            int[] street9 = new int[] { 25, 26, 27 };
            int[] street10 = new int[] { 28, 29, 30 };
            int[] street11 = new int[] { 31, 32, 33 };
            int[] street12 = new int[] { 34, 35, 36 };

            int[] result = new int[] { };
            if (street1.Contains(bet))
                result = street1;
            else if (street2.Contains(bet))
                result = street2;
            else if (street3.Contains(bet))
                result = street3;
            else if (street4.Contains(bet))
                result = street4;
            else if (street5.Contains(bet))
                result = street5;
            else if (street6.Contains(bet))
                result = street6;
            else if (street7.Contains(bet))
                result = street7;
            else if (street8.Contains(bet))
                result = street8;
            else if (street9.Contains(bet))
                result = street9;
            else if (street10.Contains(bet))
                result = street10;
            else if (street11.Contains(bet))
                result = street11;
            else if (street12.Contains(bet))
                result = street12;

            return result;
        }

        public static string getColumns(int bet)
        {
            int[] Col3 = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            int[] Col2 = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] Col1 = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };

            string column = "";
            if (Col1.Contains(bet))
                column = "Column 1";
            else if (Col2.Contains(bet))
                column = "Column 2";
            else if (Col3.Contains(bet))
                column = "Column 3";
            return column;
        }

        public static string getDozens(int bet)
        {
            string result = "";
            if (bet == 0)
                return result;
            else if (bet < 13)
                result = "1st Dozen";
            else if (bet > 18)
                result = "3rd Dozen";
            else
                result = "2nd Dozen";
            return result;
        }

        public static string getLowhigh(int bet)
        {
            string result = "";
            if (bet == 0)
                return result;
            else if (bet > 18)
                result = "High";
            else
                result = "Low";
            return result;
        }

        public static string getEvenOdd(int bet)
        {
            string evenOdd = "";
            if (bet % 2 == 0)
                evenOdd = "Even";
            else
                evenOdd = "Odd";
            return evenOdd;
        }

        public static string getColor(int bet)
        {
            int[] Rnum = new int[] { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] Bnum = new int[] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };

            string betcolor = "";
            if (Rnum.Contains(bet))
                betcolor = "Red";

            else if (Bnum.Contains(bet))
                betcolor = "Black";

            else
                betcolor = "Green";
            return betcolor;
        }

    }
}
