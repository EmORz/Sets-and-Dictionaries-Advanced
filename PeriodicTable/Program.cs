using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            SortedSet<string> data = new SortedSet<string>();
            for (int i = 0; i < count; i++)
            {
                string[] elemnts = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < elemnts.Length; j++)
                {
                    data.Add(elemnts[j]);
                }
            }
            Console.WriteLine(string.Join(" ", data));
        }
    }
}
