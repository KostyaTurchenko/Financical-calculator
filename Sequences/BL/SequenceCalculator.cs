using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class SequenceCalculator
    {
        public double X { get; set; }
        public int N { get; set; }

        public double Fault { get; private set; }

        public SequenceCalculator(double X, int N)
        {
            this.X = X;
            this.N = N;
        }

        private int Factorial(int numb)
        {
            int result = 1;
            for (int i = numb; i > 1; i--)
                result *= i;
            return result;
        }


        public double GetResult ()
        {
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += Math.Pow(-1, i) * Math.Pow(X, i) / Factorial(i);
            }

            Fault = Math.Abs(Math.Pow(Math.E, -X) - sum);

            return sum;
        }

        public double CompareFaultAndLast() => Math.Abs(Fault - Math.Pow(-1, N) * Math.Pow(X, N) / Factorial(N));


    }
}
