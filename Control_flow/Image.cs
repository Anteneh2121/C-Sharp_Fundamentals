using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height;
            int width;
           
            Console.WriteLine("Enter the value of hight");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter the value of width");
            width = Convert.ToInt32(Console.ReadLine());
            if(height > width)
            {
                Console.WriteLine(" the image is portrate");
            }
            else
            {
                Console.WriteLine(" the image is landscap");
            }
        }
    }
}
