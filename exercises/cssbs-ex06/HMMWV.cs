using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssbs_ex06
{
    class HMMWV: Vehicles
    {
        public static void HMMWVDeclaration(string name)
        {
            Console.WriteLine($"Hi I'm a {name} and I will drive all over your lands and break stuff");
        }
    }
}
