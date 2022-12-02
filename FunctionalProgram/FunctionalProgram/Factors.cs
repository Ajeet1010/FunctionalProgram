using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class Factors
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Enter number to find factors:  ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                bool isPrimeNumber = true;
                int no = 1;

                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }
                if (isPrimeNumber)

                    Console.WriteLine("{0}", i);
                no = no * i;
            }
            Console.WriteLine("Factorial of prime numbers : " + n);
        }
    }
}