using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class Evenodd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no to check even or odd: ");
            int digit = Convert.ToInt32(Console.ReadLine());

            if(digit % 2 == 0)
            {
                Console.WriteLine("No is a even no: ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Number is an odd number: ");
                Console.ReadLine();
            }
        }
    }
}
