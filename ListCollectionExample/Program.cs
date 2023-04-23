using System;

namespace ListCollection
{
    class Program
    {
        static void Main (string[] args)
        {

            Console.WriteLine();

            //sample list creation and adding data to list using .Add("")
            var names = new List<string> {"Ajinkya", "Pratiksha", "Amul", "Sakshi", null};
            names.Add("Ajay");
            names.Add("Sam");
            Console.WriteLine("Close friends in my list are:");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            // .Remove("") to delete list elements
            var num = new List<int> {0, 1, 5, 9, 8, 7, 6, 4};
            num.Remove(5);
            num.Remove(9);
            num.Sort();
            Console.WriteLine("Elements apart from deleted ones are: ");
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}