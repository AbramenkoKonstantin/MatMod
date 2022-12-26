using System;
using System.Collections.Generic;
using System.Linq;

namespace MatMod2_2
{
    public class Sturgess : List<Interval>
    {
        public double Step { get; private set; }

        public Sturgess(List<double> values)
        {
            int count = (int)Math.Ceiling(1 + 3.3221 * Math.Log10(values.Count));

            Step = Math.Round((values.Max() - values.Min()) / count, 3);

            Intervals(values, count);
        }

        private void Intervals(List<double> values, int inrevalsCount)
        {
            double lowBord = values.Min() - 0.001;
            double upBord = values.Min() + Step;
            for (int intervalIndex = 0; intervalIndex < inrevalsCount; ++intervalIndex)
            {
                Add(new Interval(values.Where(value => lowBord < value && value <= upBord).Count(), lowBord, upBord, intervalIndex));
                lowBord = upBord;
                upBord += Step;
            }
        }
    }

    public class Interval
    {
        public int Count { get; private set; }
        public double LowBord { get; private set; }
        public double UpBord { get; private set; }
        public double Mid { get; private set; }
        public int Index { get; private set; }

        public Interval(int count, double lowBord, double upBord, int index)
        {
            Count = count;
            LowBord = lowBord;
            UpBord = upBord;
            Mid = (lowBord + upBord) / 2;
            Index = index;
        }
    }
}
