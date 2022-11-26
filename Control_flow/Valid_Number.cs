using System;


namespace Valid_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine(" Enter the number between 1 and 10");
            number = Convert.ToInt32(Console.ReadLine());
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine(" valid number");
            }
            else
            {
                Console.WriteLine(" invalid number");
            }
        }
    }
}
