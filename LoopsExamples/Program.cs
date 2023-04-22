using System;

namespace LoopsExamples
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine();
            
            Console.WriteLine("while loop output");
            // while loop
            int count1 = 0;
            while (count1 < 10)
            {
                Console.WriteLine("The count value is: " +count1);
                count1 ++;
            }

            Console.WriteLine();

            Console.WriteLine("do-while loop output");
            // do-while loop
            int count2 = 0;
            do
            {
                Console.WriteLine("The count value is: " +count2);
                count2 ++;
            } while (count2 < 10);

            Console.WriteLine();

            Console.WriteLine("for loop output");
            // for loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("The count value is: " +i);
            }

            Console.WriteLine();

            Console.WriteLine("nested for loop output");
            // nested for loop
            for (int i1 = 0; i1 < 10; i1++)
            {
                for (int j1 = 0; j1 < 10; j1++)
                {
                    Console.WriteLine("The count value of j loop is: " +j1);
                }
            Console.WriteLine("The count value of i loop is: " +i1);
            }

            Console.WriteLine();
        }
    }
}