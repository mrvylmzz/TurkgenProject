using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkgenProject.Models
{
    public class Traveler
    {
        private Coordinate _travelerCoordinate;
        private Direction _travelerDirection;
        private string _orientationList;

        public int X { get { return _travelerCoordinate.X; } }
        public int Y { get { return _travelerCoordinate.Y; } }
        public Direction TravelerDirection { get { return _travelerDirection; } }

        public Traveler(int xCor, int yCor, char startDir,string orientation )
        {
            _travelerCoordinate = new Coordinate(xCor, yCor);
            _travelerDirection = GetDirection(startDir);
            _orientationList = orientation;
        }

        private Direction GetDirection(char _startDir)
        {
            switch (_startDir)
            {
                case 'N':
                    return Direction.North;
                case 'S':
                    return Direction.South;
                case 'E':
                    return Direction.East;
                case 'W':
                    return Direction.West;
                default:
                    throw new Exception("Unknown Direction Supplied. Accepted values are N,S,E,W");
            }
        }

        public void OrientationList()
        {
            foreach (char orientation in _orientationList)
            {
                ProcessOrientation(orientation);
            }
        }

        public void ProcessOrientation(char orientation)
        {
            if ((orientation == 'L') || (orientation == 'R'))
            {
                ProcessDirectionOrientation(orientation);
            }
            else if (orientation == 'M')
                ProcessMoveOrientation();
            else
                throw new Exception("Invalid Instruction Processed. Please supply only L,R and M");
        }

        public void ProcessMoveOrientation()
        {
            _travelerCoordinate.CoordinateControl(_travelerDirection);
        }

        public void ProcessDirectionOrientation(char orientation)
        {
            int travelerDir = (int)this._travelerDirection;

            if (orientation == 'L')
            {
                if (travelerDir == 0)
                    travelerDir = 4;
                this._travelerDirection = (Direction)(travelerDir - 1);
            }
            else
            {
                if (travelerDir == 3)
                    travelerDir = -1;
                this._travelerDirection = (Direction)(travelerDir + 1);
            }

        }

    }
}
