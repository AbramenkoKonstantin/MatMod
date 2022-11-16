using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatMod1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int xFirst, a, b, M, xNext;
            double[] xi = new double[100];
            double[] ui = new double[100];
            Console.Write("Введите x1: ");
            xFirst = int.Parse(Console.ReadLine());
            Console.Write("Введите a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Введите M: ");
            M = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("xi = { " + xFirst);
            xi[0] = xFirst;
            for (int iterator = 1; iterator < 100; iterator++)
            {
                xNext = (a * xFirst + b) % M;
                xFirst = xNext;
                xi[iterator] = xNext;
                Console.Write(", " + xNext);
            }
            Console.Write(" }");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("ui = { ");
            for (int iterator = 0; iterator < 99; iterator++)
            {
                ui[iterator] = xi[iterator] / M;
                Console.Write(ui[iterator] + ", ");
            }
            Console.Write(xi[99] / M);
            Console.Write(" }");
            Console.ReadLine();
        }
    }
}
