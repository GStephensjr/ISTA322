using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssbs_ex06
{
    class Smallarms: Weapons
    {
        public static void armsStatement(string name, string sound)
        {
            Console.WriteLine($"Hi, I am a {name} and I go {sound}");
        }
    }
}
