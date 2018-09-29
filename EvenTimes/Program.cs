using System;
using System.Collections.Generic;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> num = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (!num.ContainsKey(numbers))
                {
                    num.Add(numbers, 0);
                }
                num[numbers]++;          

            }
            foreach (var nn in num)
            {
                if (nn.Value % 2 ==0)
                {
                    Console.WriteLine(nn.Key);
                }

            }
        }
    }
}
