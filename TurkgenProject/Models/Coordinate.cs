using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkgenProject.Models
{
    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate(int xCor, int yCor)
        {
            X = xCor;
            Y = yCor;
        }

        public void CoordinateControl(Direction direction)
        {
            if (direction.ToString() == "North")
                Y++;

            else if (direction.ToString() == "South")
                Y--;

            else if (direction.ToString() == "East")
                X++;

            else
                X--;
        }


    }
}
