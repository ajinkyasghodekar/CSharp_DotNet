using System;

namespace ArrayExamples
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine();

            // sample integer array
            int[] a1 = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            Console.WriteLine(a1.Length);
            for (int i = 0; i < a1.Length; i++)
            {
                Console.WriteLine($"All array elements with indexe {i} and value is {a1[i]}");
            }

            // Array with size decleration and use of foreach loop
            string[] a2 = new string[5] {"Ajinkya", "Pratiksha", "Amul", "Ajay", "Sakshi"};
            foreach (var item in a2)
            {
                Console.WriteLine(item);
            }            
            
            // Array decleration in diffret way and use of for loop
            char[] a3; 
            a3 = new char[5] {'A', 'B', 'C', 'D', 'E'}; 
            foreach (var item in a3)
            {
                Console.WriteLine(item);
            }

            // var datatype
            var a = 10;          // Here var is taken as int
            var s = "Ajinkya";   // Here var is taken as string
            var d = 3.22;        // Here var is taken as double

            Console.WriteLine();
        }
    }
}