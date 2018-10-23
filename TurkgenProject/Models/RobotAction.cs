using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkgenProject.Models
{
    public class RobotAction
    {
        private Coordinate _maxCoordinate;
        private List<object> actionOnPlane;

        public RobotAction(Coordinate maxCoordinate)
        {
            _maxCoordinate = maxCoordinate;
            actionOnPlane = new List<object>();
        }

        public void AddTravelerAction(Traveler traveler)
        {
            actionOnPlane.Add(traveler);
        }

        public void MoveAllTraveler()
        {
            foreach (Traveler item in actionOnPlane)
            {
                item.OrientationList();
                StayPlane(item);
            }
        }

        public void StayPlane(Traveler item)
        {       
            if ((item.X == _maxCoordinate.X) && (item.Y==_maxCoordinate.Y))
            {
                throw new Exception("You're out of bounds.");
            }

        }

        public override string ToString()
        {
            StringBuilder _AllRoversState = new StringBuilder();
            _AllRoversState.Append("**********************************");
            _AllRoversState.Append(Environment.NewLine);
            _AllRoversState.Append(String.Format("Max Coordinates: X: {0},Y: {1}", _maxCoordinate.X, _maxCoordinate.Y));
            _AllRoversState.Append(Environment.NewLine);
            foreach (Traveler item in actionOnPlane)
            {
                _AllRoversState.Append(String.Format("Traveler Details -- X:{0},Y:{1},Direction:{2}", item.X, item.Y, item.TravelerDirection));
                _AllRoversState.Append(Environment.NewLine);
            }
            _AllRoversState.Append("**********************************");
            return _AllRoversState.ToString();
        }

    }
}
