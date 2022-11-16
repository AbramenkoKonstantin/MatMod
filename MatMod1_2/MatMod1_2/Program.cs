using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatMod1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = 0.2152;
            double square;
            
            for (int iterator = 0; iterator < 100; ++iterator)
            {
                square = number * number;
                string strSquare = square.ToString();
                Console.WriteLine(iterator + 1 + ")" + number + " " + square);
                number = Math.Truncate(double.Parse(strSquare.Remove(2, 2)) * 10000) / 10000;
            }
            Console.ReadLine();
        }
    }
}
