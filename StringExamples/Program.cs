using System;

namespace StringExample
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine();

            // { } are string interpolition to get a values of declared variables
            string s1 = "Abhay";
            string s2 = "Amul";
            string s3 = "Samir";
            Console.WriteLine($"Ajinkya has three friends and they are {s1}, {s2} and {s3}.");  

            // get a length of a string using .Length()
            string s4 = "Ajinkya is a Software Engineer";
            Console.WriteLine("The length os the s4 string is: " +s4.Length);

            // .TrimEnd(), .TrimStart(), .Trim() in a string
            string s5 = "      Hello Ajinkya        ";
            Console.WriteLine($"[{s5}]");
            string s6 = s5.TrimEnd();
            Console.WriteLine($"[{s6}]");
            string s7 = s6.TrimStart();
            Console.WriteLine($"[{s7}]");
            string s8 = s5.Trim();
            Console.WriteLine($"[{s8}]");

            // .ToUpper() and .ToLower() case in string
            string s9 = "Ajinkya Ghodekar";
            Console.WriteLine($"Name to Upper case: " +s9.ToUpper());
            Console.WriteLine($"Name to Lower case: " +s9.ToLower());

            // Searching in a string using .Contains("")
            string s10 = "My name is Ajinkya, I am working as a Software Engineer";
            Console.WriteLine(s10.Contains("ajinkya"));
            Console.WriteLine(s10.Contains("Engineer"));

            // .StartWith("") and .EndsWith("") in string
            string s11 = "My name is Ajinkya, I am working as a Software Engineer";
            Console.WriteLine(s10.StartsWith("My"));
            Console.WriteLine(s10.EndsWith("Ajinkya"));

            Console.WriteLine();

        }
    }
}