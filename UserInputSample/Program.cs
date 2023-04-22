using System;

namespace UserInput
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine();

            string fname, mname, lname;
            Console.Write("Enter your first name: ");
            fname = Console.ReadLine();

            Console.Write("Enter your middle name: ");
            mname = Console.ReadLine();

            Console.Write("Enter your last name: ");
            lname = Console.ReadLine();

            Console.WriteLine($"Your full name is {fname} {mname} {lname}");
            
            Console.WriteLine();
        }
    }
}