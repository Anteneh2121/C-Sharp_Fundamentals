//3- Write a program and ask the user to enter 5 numbers.
//If a number has been previously entered, display an error message and ask the user to re-try.
//Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_number.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            while(numbers.Count < 5)
            {
                Console.WriteLine(" enter number");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine(" you have privisly enterd " + number);
                    continue;
                }
                numbers.Add(number);

            }
            numbers.Sort();
            foreach( var number in numbers)
                Console.WriteLine(number); 


        }
    }
}
