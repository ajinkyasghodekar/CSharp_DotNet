using System;

namespace BranchesExamples
{
    class Program
    {
        
        static void Methodm1()
        {
            int n1 = 4;
            int n2 = 6;
            int n3 = 4;
            if ((n1 == n2) && n1 == n3)
            {
                Console.WriteLine("The if condition is true.");
            }
            else
            {
                Console.WriteLine("The if condition is not true.");
            }

            if ((n1 == n2) || n1 == n3)
            {
                Console.WriteLine("The if condition is true.");
            }
            else
            {
                Console.WriteLine("The if condition is not true.");
            }
        }
        
        static void Main (string[] args)
        {
            int a = 10;
            int b = 5;
            
            
            Console.WriteLine();
            
            // Simple if condition without else
            if (a + b > 10)
                Console.WriteLine("Then given condition is true. And if block is executed.");

            // if-else condition with bool type
            bool temp = a > b;
            if (temp)
            {
                Console.WriteLine("a is greater than b.");
            }
            else
            {
                Console.WriteLine("a is not greater than b.");
            }
            
            // B using && and || operator
            int n1 = 4;
            int n2 = 6;
            int n3 = 4;
            if ((n1 == n2) && n1 == n3)
            {
                Console.WriteLine("The if condition is true.");
            }
            else
            {
                Console.WriteLine("The if condition is not true.");
            }

            if ((n1 == n2) || n1 == n3)
            {
                Console.WriteLine("The if condition is true.");
            }
            else
            {
                Console.WriteLine("The if condition is not true.");
            }


            // Method calling (Methods written in above class)
            Console.WriteLine("The Method call Methodm1 output is:");
            Methodm1();

            Console.WriteLine();
        }
    }
}