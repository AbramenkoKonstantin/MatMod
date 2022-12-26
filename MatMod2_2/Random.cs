using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MatMod2_2
{
    public class RandomClass : List<double>
    {
        public double ME { get; private set; }
        public double Disp { get; private set; }
        public double Sigma { get; private set; }

        public RandomClass(int count, double lambda)
        {
            for (int i = 0; i < count; ++i)
            {
                Thread.Sleep(1);
                Add(Math.Round(-1 * Math.Log(new Random().NextDouble()) / lambda, 2));
            }

            Sort();
            
            ME = Math.Round(this.Sum() / count, 2);

            Disp = Math.Round(this
                .Select(value => Math.Pow(value - ME, 2))
                .Sum() / (count - 1), 2);

            Sigma = Math.Sqrt(Disp);
        }
    }
}
