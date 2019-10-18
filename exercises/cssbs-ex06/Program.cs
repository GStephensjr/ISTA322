using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssbs_ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("New guy Carl: ");
            String carl = "Carl";
            Operators.personnelDeclaration(carl);
            Operators.operatorDeclaration();
            Console.WriteLine("");

            Console.WriteLine("New guys Dennis: ");
            String Dennis = "Dennis";
            Support.personnelDeclaration(Dennis);
            Support.supportDeclaration();
            Console.WriteLine("");

            Console.WriteLine("Weapons: ");
            string pistol = "pistol";
            string bang = "bang";
            string rifle = "rifle";
            string pop = "pop";
            Smallarms.armsStatement(pistol, pop);
            Smallarms.armsStatement(rifle, bang);
            Smallarms.weaponsCheck();
            Console.WriteLine("");

            Console.WriteLine("Vehicles: ");
            string humvee = "M1145A";
            string aircraft = "AH-64 Apache Helicopter";
            string also = "also ";
            string eh = "";

            HMMWV.HMMWVDeclaration(humvee);
            HMMWV.vehicleDeclaration(eh);
            Aircraft.aircraftDeclaration(aircraft);
            Aircraft.vehicleDeclaration(also);
            Console.WriteLine("");

            Console.WriteLine("Missions: ");
            Tactical.tacticalMission(carl);
            Tactical.MissionStatement(eh);
            Strategic.strategicMission(Dennis);
            Strategic.MissionStatement(also);
        }
    }
}
