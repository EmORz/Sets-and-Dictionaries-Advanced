using System;
using System.Collections.Generic;

namespace RecordUniqueNames
{
    class Start
    {
        static void Main(string[] args)
        {
            HashSet<string> dataCollection = new HashSet<string>();
            int count = int.Parse(Console.ReadLine());
            while (count>0)
            {
                string input = Console.ReadLine();
                dataCollection.Add(input);
                count--;
            }
            Console.WriteLine();
            Console.WriteLine(string.Join("\n", dataCollection));
        }
    }
}
