using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();

            Dictionary<char, int> symbolsCollection = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!symbolsCollection.ContainsKey(input[i]))
                {
                    symbolsCollection.Add(input[i], 0);
                }
                symbolsCollection[input[i]]++;
            }

            foreach (var ch in symbolsCollection.OrderBy(x => x.Key))
            {
                Console.WriteLine(ch.Key+":"+$" {ch.Value} time/s");
            }
        }
    }
}
