using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedCamera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int speedLimit;
            int carspeed;
            int numberOfDemeritPoint;
            Console.WriteLine(" enter the value of the speedLimit");
            speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter the value of the car speed");
            carspeed = Convert.ToInt32(Console.ReadLine());

            if (speedLimit > carspeed)
            {
                Console.WriteLine(" Ok");
            }
             else
            {
                numberOfDemeritPoint = (carspeed - speedLimit)/ 5;
                if (numberOfDemeritPoint > 12)
                {
                    Console.WriteLine(" license suspended");
                }
                else
                {
                    Console.WriteLine("Demerit points:" + numberOfDemeritPoint);
                }

            }

        }
    }
}
