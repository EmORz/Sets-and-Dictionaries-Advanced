using System;
using System.Collections.Generic;

namespace UniqueUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            HashSet<string> data = new HashSet<string>();

            while (count-->0)
            {
                string[] input = Console.ReadLine().Split();
                data.Add(input[0]);

            }
            Console.WriteLine(string.Join("\n", data));
        }
    }
}
