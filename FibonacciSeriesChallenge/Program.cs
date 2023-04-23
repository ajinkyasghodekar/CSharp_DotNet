using System;

namespace FibonacciSeries
{
    class Program
    {
        // write a c# code to get a addition of fibonacci series from range 1 to 20:
        static void Main (string[] args)
        {
            var fs = new List<int> {1,1};

            while (fs.Count < 20)
            {
                var prev1 = fs[fs.Count - 1]; // to get a 1st position at initial step and so on
                var prev2 = fs[fs.Count - 2]; // to get a 0th position at initial step and so on
                fs.Add(prev1 + prev2);
            }
            foreach (var item in fs)
            {
                Console.WriteLine(item);
            }
        }
    }
}