using System;

namespace Problem1
{
    class Program
    {

        // Problem Statement:
        // Write C# code to find the sum of all integers 1 through 20 that are divisible by 3
        // Using method call
        static void Method1()
        {
            int sum = 0;
            for (int i = 1; i < 20; i++)
            {
                if (i % 3 == 0)
                {
                    sum = sum + i;

                }
            }
            Console.WriteLine("The sum of all integers 1 through 20 that are divisible by 3 is: " +sum);
        }
        static void Main (string[] args)
        {
            // Method calling
            Method1();
        }
    }
}