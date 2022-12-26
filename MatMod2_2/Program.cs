using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MatMod2_2
{
    public class Program
    {
        private const int count = 100;
        private const double lambda = 0.1;
        private const double ThME = 1 / lambda;
        private const double ThDisp = 1 / (lambda * lambda);
        private static readonly Dictionary<int, double> Table = new Dictionary<int, double>{
            { 1, 3.8 }, { 2, 6.0 }, { 3, 7.8 }, { 4, 9.5 },
            { 5, 11.1 }, { 6, 12.6}, {7, 14.1}, {8 , 15.5}
        };
        public double Step { get; private set; }

        static void Main(string[] args)
        {
            RandomClass random = new RandomClass(count, lambda);
            Sturgess intervals = new Sturgess(random);
            //МО
            Console.WriteLine("Теоретическое МО = " + ThME);
            Console.WriteLine("Оценка МО = " + random.ME);
            Console.WriteLine("Ошибка МО = " + Math.Round(ThME - random.ME, 2));

            Console.WriteLine();

            //Дисперсия
            Console.WriteLine("Теоретическая дисперсия = " + ThDisp);
            Console.WriteLine("Оценка дисперсии = " + random.Disp);
            Console.WriteLine("Ошибка дисперсия = " + Math.Round(ThDisp - random.Disp, 2) + "\n");

            double xMid = (double)intervals.Select(interval => interval.Mid * interval.Count).Sum() / intervals.Select(interval => interval.Count).Sum();

            List<double> periodicity = intervals.Select(interval => (double)interval.Count).ToList();
            List<double> thPeriodicity = GetThPeriodicity(intervals, xMid);

            Console.WriteLine("Количество интервалов = " + intervals.Count + "\nШаг = " + intervals.Step);
            Console.WriteLine("\nИнтервалы:");
            for (int index = 0; index < intervals.Count; index++)
            {
                Console.WriteLine("Частота = " + periodicity[index] + ", теор. частота = " + thPeriodicity[index]);
            }
            Console.WriteLine();

            for (int i = intervals.Count - 1; i > 0; --i)
            {
                if (periodicity[i] < 5)
                {
                    periodicity[i - 1] += periodicity[i];
                    periodicity.Remove(periodicity[i]);
                    thPeriodicity[i - 1] += thPeriodicity[i];
                    thPeriodicity.Remove(thPeriodicity[i]);
                }
            }

            Console.WriteLine("Интервалы после объединения частот:");
            for (int index = 0; index < periodicity.Count; index++)
            {
                Console.WriteLine("частота = " + periodicity[index] + ", теор. частота = " + thPeriodicity[index]);
            }
            Console.WriteLine();

            double Xi2 = 0;
            for (int index = 0; index < periodicity.Count; index++)
            {
                Xi2 += Math.Pow(periodicity[index] - thPeriodicity[index], 2) / thPeriodicity[index];
            }
            Xi2 = Math.Round(Xi2, 3);
            int degreesOfFreedom = periodicity.Count - 2;
            double Xi2Crit = Table[periodicity.Count - 2];

            Console.WriteLine("Наблюдаемый X^2 = " + Xi2 + "\nЧисло степеней свободы = " + degreesOfFreedom + "\nУровне значимости = 0,05" + "\nКритический X^2 = " + Xi2Crit + "\n" + ((Xi2 < Xi2Crit) ? "Наблюдаемый X^2 < критического X^2 => гипотеза принимается" : "Наблюдаемый X^2 >= критического X^2 => гипотеза отвергается"));

            Console.ReadLine();
        }

        private static List<double> GetThPeriodicity(Sturgess intervals, double xMid)
        {
            List<double> result = new List<double>();
            for (int index = 0; index < intervals.Count; index++)
            {
                result.Add(new double());
                if (intervals[index].Count != 0)
                {
                    double Pi = Math.Exp(-1 * intervals[index].LowBord / xMid) - Math.Exp(-1 * intervals[index].UpBord / xMid);
                    result[index] = Math.Round(count * Pi, 2);
                }
            }
            return result;
        }
    }
}
