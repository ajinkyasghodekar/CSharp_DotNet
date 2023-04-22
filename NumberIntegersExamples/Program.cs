using System;

namespace NumberIntegerExamples
{
    class Program
    {
        static void Main (string[] agrs)
        {
            Console.WriteLine();

            // simple Addition, Substraction, Multiplication, Division of two numbers
            int i1 = 10;
            int i2 = 20;
            int add = i1 + i2;
            Console.WriteLine("The addition of two numbers is " +add);
            int sub = i1 - i2;
            Console.WriteLine("The Substraction of two numbers is " +sub);
            int mul = i1 * i2;
            Console.WriteLine("The Multiplication of two numbers is " +mul);
            int div = i1 / i2;
            Console.WriteLine("The Division of two numbers is " +div);

            // Experession in integer
            int exp = (i1 + i2) * 3;
            Console.WriteLine("The experession value is " +exp);

            // Modulo % operator
            int i3 = 10;
            int i4 = 3;
            int mod = i3 % i4;
            Console.WriteLine("The Modulo value is " +mod);

            // .MinValue and .MaxValue range of Integer in C#
            int min = int.MinValue;
            int max = int.MaxValue;
            Console.WriteLine($"The range of integer ranges for {min} to {max}.");

            Console.WriteLine();
        }
    }
}