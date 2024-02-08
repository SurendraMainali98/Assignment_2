using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Interval
    {
        static void Main(string[] args)
        {   
            // Taking input from user
            Console.WriteLine("Enter a real number: ");
            double x = double.Parse(Console.ReadLine());

            // Using If/else condition
            if ((x >= 2 && x < 3) || (x >= 0 && x <= 1) || (x >= -10 && x <= -2))
            {
                Console.WriteLine("x belongs to I");
            }
            else
            {
                Console.WriteLine("x does not belong to I");
            }
        }
    }
}
