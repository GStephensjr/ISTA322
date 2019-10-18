using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssbs_ex06
{
    class Strategic: Missions
    {
        public static void strategicMission(string name)
        {
            Console.WriteLine("Fix equipment cuz operators dont know how to not break their stuff");
            Console.WriteLine($"I am assigned to {name}");
        }
    }
}
