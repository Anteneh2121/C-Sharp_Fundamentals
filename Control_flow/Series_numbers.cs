// 5 - Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter a series of numbers separated by comma");
            var numbers = Console.ReadLine();
            var Series = numbers.Split(',');
            var Maximum = Convert.ToInt32(Series[0]);
            foreach( var num in Series)
            {
                var number = Convert.ToInt32(num);
                if(number > Maximum)
                {
                    Maximum = number;
                    
                   // Console.WriteLine("Maximum is" + Maximum);
                }
                //Console.WriteLine(" the Maximum number from the lis is :"+ Maximum);
            }
            Console.WriteLine(" the Maximum number from the lis is :" + Maximum);


        }
    }
}
