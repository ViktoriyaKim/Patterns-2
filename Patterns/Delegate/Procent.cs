using System;

namespace Patterns.Delegate
{
    class Procent
    {
        public int CountSumTruncuated(double sum, int procent)
        {
            return (int)Math.Round(CountSum(sum, procent));
        }

        private double CountProcent(double sum, int procent)
        {
            return Math.Round((double)(sum * procent / 100));
        }

        private double CountSum(double sum, int procent)
        {
            return sum + CountProcent(sum, procent);
        }
    }
}
