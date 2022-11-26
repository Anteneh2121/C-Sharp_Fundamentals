using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int maximum;
            Console.WriteLine(" Enter number1 value");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter the value of num 2");
            number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
            {
                maximum = number1;
                Console.WriteLine(" the maximum number is num1");
                Console.WriteLine( maximum);
            }
            else
            {
                maximum = number2;
                Console.WriteLine(" the maximum number is number2");
                Console.WriteLine(maximum);
            }
        }
    }
}
