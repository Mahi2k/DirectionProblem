using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectionProblem
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the initial position in Format X Y Direction : ");
            var inputPositionOfRobot = Console.ReadLine();

            Console.WriteLine("Enter the moves : ");
            var moveStrings = Console.ReadLine();

            PositionOfRobot robotPositionObj = new PositionOfRobot();

            //Check Validity of input string.
            if (robotPositionObj.isValid(inputPositionOfRobot))
            {
                int x, y = 0;
                Int32.TryParse(inputPositionOfRobot[0].ToString(), out x);
                Int32.TryParse(inputPositionOfRobot[2].ToString(), out y);

                robotPositionObj.X = x;
                robotPositionObj.Y = y;
                robotPositionObj.D = robotPositionObj.GetDirectionFromInput(inputPositionOfRobot[4]);
            }
            else
            {
                foreach (var item in ErrorMessageContainer.listofErrorMsg)
                {
                    Console.WriteLine(item);
                    Console.ReadLine();
                }
            }


            //Move all the property according to string
            foreach (var move in moveStrings)
            {
                switch (move.ToString().ToLower()){
                    case "m":
                        robotPositionObj.movePositionOfRobot();
                        break;
                    case "r":
                        robotPositionObj.changeDirectionToRight();
                        break;
                    case "l":
                        robotPositionObj.changeDirectionToLeft();
                        break;
                    default:            
                        break;
                }
                
            }

            Console.WriteLine();
            Console.WriteLine("************** Output Coordinates ************");
            Console.WriteLine(robotPositionObj.X + " " + robotPositionObj.Y + " " + robotPositionObj.D);
            Console.ReadLine();

        }

    }

}
