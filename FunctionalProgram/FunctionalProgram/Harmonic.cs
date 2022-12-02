using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class Harmonic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            float s = 1 / 1;
            for (int i = 1; i <= n; i++)
            {
                s +=  1 / (float)i;
            }
            Console.WriteLine("The sum of harmonic numbers are: ", s);
        }
    }
}
