using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValueInArr
{
    class Start
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(Double.Parse).ToArray();
            Dictionary<double, int> data = new Dictionary<double, int>();
            for (int n = 0; n < input.Length; n++)
            {
                if (!data.ContainsKey(input[n]))
                {
                    data[input[n]] = 1;
                }
                else
                {
                    data[input[n]]++;
                }
            }

            foreach (var nums in data)
            {
                Console.WriteLine($"{nums.Key} - {nums.Value} times");
            }
        }
    }
}
