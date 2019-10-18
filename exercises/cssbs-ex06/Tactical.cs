using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssbs_ex06
{
    class Tactical: Missions
    {
        public static void tacticalMission(string name)
        {
            Console.WriteLine("Go kick in doors and clear some floors");
            Console.WriteLine($"I am assigned to {name}");
        }
    }
}
