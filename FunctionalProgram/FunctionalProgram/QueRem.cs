using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class QueRem
    {
        static void Main(string[] args)
        {
            int x, y, z, a, b;
            Console.WriteLine("Enter the first no");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second no");
            y = Convert.ToInt32(Console.ReadLine());
            z = x / y;
            a = z * y;
            b = x - a;
            Console.WriteLine("Remainder of {0}", b);
            Console.ReadLine();
            Console.WriteLine("Quotient of {0}", a);
            Console.ReadLine();
        }
    }
}