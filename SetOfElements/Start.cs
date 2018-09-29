using System;
using System.Collections.Generic;
using System.Linq;

namespace SetOfElements
{
    class Start
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var first = arr[0];
            var second = arr[1];
            //
            HashSet<int> f = new HashSet<int>();
            HashSet<int> s = new HashSet<int>();
            //
            for (int i = 0; i < first; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                f.Add(temp);
            }
            for (int i = 0; i < second; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                s.Add(temp);
            }
            var equalElents = f.Where(a => s.Any(a1 => a1 == a)).ToList();

            Console.WriteLine(string.Join(" ", equalElents));
        }
    }
}
