using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class Calculator
    {
        public double Base_sum { get; private set; }
        public double Pct { get; private set; }
        public int T {get; private set; }
        public int Interval { get; private set; } 
        public Calculator(double base_sum, double pct, int time, int interval)
        {
            this.Base_sum = base_sum;
            this.Pct = pct;
            this.T = time;
            this.Interval = interval;
        }

        double GetMultiplier ()
        {
            return 1 + Pct / 1200 * Interval;
        }
        public double GetSum()
        {
            double result = Base_sum;
            double multiplier = GetMultiplier();

            for (int i = 0; i < T / Interval; i++)
                result = result * multiplier;

            return Math.Round(result, 2);
        }
    }
}
