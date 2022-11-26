using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine(" Enter number (or Ok ot Exit");
                var value = Console.ReadLine();

                if (value == "ok")
                {
                    break;
                }
                sum += Convert.ToInt32(value);
            }
            Console.WriteLine(" sum of all the number is : " +sum);
        }
    }
}
