using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatMod1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = new int[] { 0, 1, 1, 1, 0, 0, 1, 9, 0 };
            double leftInterval = 0;
            double rightInterval = 1;
            for (int iterator = 0; iterator < sequence.Length; ++iterator)
            {
                if (sequence[iterator] == 0)
                {
                    rightInterval = (rightInterval + leftInterval) / 2;
                }
                else
                {
                    leftInterval = (leftInterval + rightInterval) / 2;
                }
            }
            Console.WriteLine("[" + leftInterval + "; " + rightInterval + "]");
            Console.ReadLine();
        }
    }
}
