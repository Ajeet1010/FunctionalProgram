using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class Largestno
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number : ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("{0} is largest", a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("{0} is largest", b);
            }
            else
            {
                Console.WriteLine("{0} is largest", c);
            }
        }
    }
}
