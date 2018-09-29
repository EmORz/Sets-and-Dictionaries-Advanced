using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            var partZero = new Dictionary<string, string>();
            var data = new Dictionary<string, Dictionary<string, double>>();

            while (firstInput != "end of contests")
            {

                string[] tokens = firstInput.Split(":");
                string contest = tokens[0];
                string password = tokens[1];
                if (!partZero.ContainsKey(contest))
                {
                    partZero.Add(contest, "");
                }
                partZero[contest] = password;
                firstInput = Console.ReadLine();
            }
            firstInput = Console.ReadLine();
            while (firstInput != "end of submissions")
            {
                string[] tokens = firstInput.Split("=>");
                string contest = tokens[0];
                string password = tokens[1];
                string name = tokens[2];
                double points = double.Parse(tokens[3]);

                if (partZero.ContainsKey(contest)&&partZero.ContainsValue(password))
                {
                    if (!data.ContainsKey(name))
                    {
                        data.Add(name, new Dictionary<string, double>());
                    }
                    if (!data[name].ContainsKey(contest))
                    {
                        data[name].Add(contest, 0.0);
                    }
                    data[name][contest] = points;
                }
                firstInput = Console.ReadLine();

            }
            Dictionary<string, double> max = new Dictionary<string, double>();
            foreach (var item in data)
            {
                if (!max.ContainsKey(item.Key))
                {
                    max[item.Key] = 0.0;
                }
                foreach (var i in item.Value)
                {
                   
                    max[item.Key] += i.Value;
                }
            }
        
            var str = "";
            var num = 0.0;
            foreach (var item in max)
            {
                if (item.Value>num)
                {
                    num = item.Value;
                    str = item.Key;
                }
            }
            Console.WriteLine($"Best candidate is {str} with total {num} points.");
            Console.WriteLine("Ranking:");
            foreach (var item in data.OrderBy(x => x.Key).ThenByDescending(z => z.Value))
            {
                Console.WriteLine(item.Key);

                foreach (var it in item.Value.OrderByDescending(t => t.Value))
                {
                    Console.WriteLine($"#  {it.Key} -> {it.Value}");
                }
            }
        }
    }
}
