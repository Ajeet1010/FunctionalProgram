using FunctionalProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class BasicPraograms
    {
        static void Main(string[] args)
        {
            Flipcoin flipCoin = new Flipcoin();
            flipCoin.Flip();
            Powerof2 powerof2 = new Powerof2();
            Console.WriteLine("\n" + "Enter the power value Up To 31");
            int num = Convert.ToInt32(Console.ReadLine());
            powerof2.Power(num);
        }
    }
}