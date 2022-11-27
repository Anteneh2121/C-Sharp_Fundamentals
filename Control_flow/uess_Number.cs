using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var number = random.Next(1, 10);
            Console.WriteLine(" Guess the number between 1 and 10");
            Console.WriteLine(" Enter the number");
            for (int i = 0; i < 4; i++)
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == number)
                {
                    Console.WriteLine("You Won!!!");
                    break;
                }
                else if(guess <= 4)
                {
                    Console.WriteLine(" guess the number again");
                }
            }
            Console.WriteLine(" You lost ");
        }
    }
}
