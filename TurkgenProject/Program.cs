using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkgenProject.Models;

namespace TurkgenProject
{
    class Program
    {
        static void Main(string[] args)
        {
            RobotAction action = new RobotAction(new Coordinate(5, 5));
            action.AddTravelerAction(new Traveler(1, 2, 'N', "LMLMLMLMM"));
            action.AddTravelerAction(new Traveler(3, 3, 'E', "MMRMMRMRRM"));
            action.MoveAllTraveler();
            Console.WriteLine(action.ToString());
            Console.ReadLine();
        }
    }
}
