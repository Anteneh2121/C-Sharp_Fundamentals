using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Displaycount = 0;
            for ( int i = 1; i <= 100; i++)
            {
                if ( i % 3 == 0)
                {
                    Displaycount++;
                    
                   
                }

            }
            Console.WriteLine(" the number between 1 and 100 divisible by 3 with zero reminde is = " + Displaycount);
        }
    }
}
