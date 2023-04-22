using System;

namespace DoubleExamples
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine();

            // range of Integer, long, short, Double and decimal in C#
            int i1 = int.MinValue;
            int i2 = int.MaxValue;
            Console.WriteLine($"The range of integer is from {i1} to {i2}.");

            long l1 = long.MinValue;
            long l2 = long.MaxValue;
            Console.WriteLine($"The range of long is from {l1} to {l2}.");

            short s1 = short.MinValue;
            short s2 = short.MaxValue;
            Console.WriteLine($"The range of short is from {s1} to {s2}.");

            double d1 = double.MinValue;
            double d2 = double.MaxValue;
            Console.WriteLine($"The range of double is from {d1} to {d2}.");

            decimal di1 = decimal.MinValue;
            decimal di2 = decimal.MaxValue;
            Console.WriteLine($"The range of decimal is from {di1} to {di2}.");

            Console.WriteLine();
        }
    }
}