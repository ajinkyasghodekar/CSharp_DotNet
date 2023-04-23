using System;

namespace SearchSortIndex
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine();

            // Array example to search, sort and indexes
            
            Console.WriteLine("--------------- Array output ---------------");
            var arr1 = new string[5] {"Ajinkya", "Pratiksha", "Amul", "Sakshi", "Ajay"};
            
            // Diaplay all data
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            Console.WriteLine();

            // Search a data
            string d1 = arr1[0];
            string d2 = arr1[2];
            Console.WriteLine(d1);
            Console.WriteLine(d2); 

            Console.WriteLine();

            // Sorting all data
            Array.Sort(arr1);
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            
            Console.WriteLine("--------------- List output ---------------");
            
            // List example to search, sort and indexes
            
            var l1 = new List<string> {"Ajinkya", "Pratiksha", "Amul", "Sakshi", "Ajay"};
            
            // Diaplay all data
            foreach (var item in l1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // Search a data
            string li1 = l1[0];
            string li2 = l1[2];
            Console.WriteLine(li1);
            Console.WriteLine(li2); 

            Console.WriteLine();

            // Sorting all data
            l1.Sort();
            foreach (var item in l1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}