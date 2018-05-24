using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectionProblem
{
    public class PositionOfRobot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction D { get; set; }

        public enum Direction
        {
            North = 1, East = 2, South = 3, West = 4
        }

        public void movePositionOfRobot()
        {
            if (this.D == PositionOfRobot.Direction.West)
            {
                this.X -= 1;
            }
            else if (this.D == PositionOfRobot.Direction.East)
            {
                this.X += 1;
            }
            else if (this.D == PositionOfRobot.Direction.North)
            {
                this.Y += 1;
            }
            else if (this.D == PositionOfRobot.Direction.South)
            {
                this.Y -= 1;
            }
        }

        public void changeDirectionToRight()
        {
            if (this.D == PositionOfRobot.Direction.East)
                this.D = PositionOfRobot.Direction.South;

            else if (this.D == PositionOfRobot.Direction.South)
                this.D = PositionOfRobot.Direction.West;

            else if (this.D == PositionOfRobot.Direction.West)
                this.D = PositionOfRobot.Direction.North;

            else if (this.D == PositionOfRobot.Direction.North)
                this.D = PositionOfRobot.Direction.East;

        }

        public void changeDirectionToLeft()
        {
            if (this.D == PositionOfRobot.Direction.East)
                this.D = PositionOfRobot.Direction.North;

            else if (this.D == PositionOfRobot.Direction.North)
                this.D = PositionOfRobot.Direction.West;

            else if (this.D == PositionOfRobot.Direction.South)
                this.D = PositionOfRobot.Direction.East;

            else if (this.D == PositionOfRobot.Direction.West)
                this.D = PositionOfRobot.Direction.South;
        }

        public PositionOfRobot.Direction GetDirectionFromInput(char p)
        {
            switch (p.ToString().ToLower())
            {
                case "w":
                    return PositionOfRobot.Direction.West;

                case "n":
                    return PositionOfRobot.Direction.North;

                case "s":
                    return PositionOfRobot.Direction.South;

                case "e":
                    return PositionOfRobot.Direction.East;

                default:
                    return PositionOfRobot.Direction.East;
            }
        }

        public bool isValid(string positionOfRobot)
        {

            if (positionOfRobot.Length != 5)
            {
                ErrorMessageContainer.listofErrorMsg.Add("Initial position string length in not equals 5..!!");
                return false;
            }

            switch (positionOfRobot[4].ToString().ToLower())
            {
                case "e":
                    return true;

                case "w":
                    return true;

                case "n":
                    return true;

                case "s":
                    return true;

                default:
                    ErrorMessageContainer.listofErrorMsg.Add("Direction Is Not Valid..!!");
                    return false;
            }

        }

    }
}
