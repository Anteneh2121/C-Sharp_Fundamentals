using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the number you want to find its factorial");
            var number = Convert.ToInt32(Console.ReadLine());
            var factorial = 1;
            for(int i = number; i > 0; i--)
            {
                factorial *= i;

            }
            Console.WriteLine(" {0}! = {1}", number, factorial);
        }
    }
}
