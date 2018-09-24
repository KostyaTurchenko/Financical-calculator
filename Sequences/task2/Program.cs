using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BL;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            SequenceCalculator MyCalc = new SequenceCalculator(x, n);

            Console.WriteLine(MyCalc.GetResult());
            Console.WriteLine("Погрешность: {0}", MyCalc.Fault);
            Console.WriteLine("Разница между погрешностью и N-го слагаемого: {0}", MyCalc.CompareFaultAndLast());
            Console.WriteLine();
            Console.WriteLine("Значение e^(-{0}): {1}",x, Math.Pow(Math.E, -x));

        }
    }
}
