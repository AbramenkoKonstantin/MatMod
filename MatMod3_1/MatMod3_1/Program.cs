using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MatMod3_1
{
    class Program
    {

        static void Main(string[] args)
        {
            double material = -20;
            double latheMachining = -5;
            double grinderMachining = -4;
            double sellingPrice = 35;
            double correctingPart = -3;
            double correctingDefects = -2;
            double profit = 0;
            double goodPart = 0;

            Random random = new Random();
            double R1;
            double R21;
            double R22;
            for (int i = 0; i < 100000; ++i)
            {
                R1 = random.NextDouble();
                if (R1 < 0.08)
                {
                    profit += material + latheMachining;
                }
                else if (R1 >= 0.08 && R1 < 0.2)
                {
                    R21 = random.NextDouble();
                    R22 = random.NextDouble();
                    if (R21 < 0.03 && R22 < 0.06)
                    {
                        profit += material + latheMachining + correctingPart + grinderMachining;
                    }
                    else if (R21 >= 0.03 && R22 >= 0.06)
                    {
                        profit += material + latheMachining + correctingPart + grinderMachining + sellingPrice;
                        goodPart += 1;
                    }
                    else
                    {
                        profit += material + latheMachining + correctingPart + grinderMachining + correctingDefects + sellingPrice;
                        goodPart += 1;
                    }
                }
                else
                {
                    R21 = random.NextDouble();
                    R22 = random.NextDouble();
                    if (R21 < 0.03 && R22 < 0.06)
                    {
                        profit += material + latheMachining + grinderMachining;
                    }
                    else if (R21 >= 0.03 && R22 >= 0.06)
                    {
                        profit += material + latheMachining + grinderMachining + sellingPrice;
                        goodPart += 1;
                    }
                    else
                    {
                        profit += material + latheMachining + grinderMachining + correctingDefects + sellingPrice;
                        goodPart += 1;
                    }
                }
            }
            Console.WriteLine("Процент годных деталей = " + goodPart / 100000);
            Console.WriteLine("Средняя прибыль от выпуска одной деталей = " + profit / 100000);
            Console.ReadLine();
        }
    }
}
