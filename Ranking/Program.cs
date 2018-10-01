using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var partZero = new Dictionary<string, string>();
            var data = new SortedDictionary<string, SortedDictionary<string, SortedSet<double>>>();

            while (input != "end of contests")
            {

                string[] tokens = input.Split(":");
                string contest = tokens[0];
                string password = tokens[1];
                if (!partZero.ContainsKey(contest))
                {
                    partZero.Add(contest, "");
                }
                partZero[contest] = password;
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "end of submissions")
            {
                string[] tokens = input.Split("=>");
                string contest = tokens[0];
                string password = tokens[1];
                string name = tokens[2];
                double points = double.Parse(tokens[3]);

                if (partZero.ContainsKey(contest) && partZero.ContainsValue(password))
                {
                    if (!data.ContainsKey(name))
                    {
                        data.Add(name, new SortedDictionary<string, SortedSet<double>>());
                    }
                    if (!data[name].ContainsKey(contest))
                    {
                        data[name].Add(contest, new SortedSet<double>());
                    }
                    data[name][contest].Add(points);

                }
                input = Console.ReadLine();

            }
            var maxResult = 0.0;
            var searchName = "";
            var finalName = "";
            var finalScore = 0.0;
            var max = new List<double>();
            var searchBestScore = new Dictionary<string, double>();
            //
            foreach (var item in data)
            {
                searchName = item.Key;
                foreach (var score in item.Value)
                {
                    maxResult += score.Value.Max();
                }
                if (!searchBestScore.ContainsKey(searchName))
                {
                    searchBestScore.Add(searchName, 0.0);
                }
                searchBestScore[searchName] = maxResult;
                maxResult = 0.0;
            }
            var count = 0;
            foreach (var item in searchBestScore.OrderByDescending(x => x.Key).ThenBy(x => x.Value))
            {
                if (count == 0)
                {
                    finalName = item.Key;
                    finalScore = item.Value;
                    break;
                }
            }
            Console.WriteLine($"Best candidate is {finalName} with total {finalScore} points.");
            //
            Console.WriteLine("Ranking:");
            foreach (var item in data)
            {
                Console.WriteLine(item.Key);
                searchName = item.Key;
                foreach (var score in item.Value.OrderBy(x => x.Key).ThenByDescending(z => z.Value))
                {
                    Console.Write("#  " + score.Key + " -> ");
                    Console.WriteLine(score.Value.Max());
                    maxResult += score.Value.Max();
                }
                if (!searchBestScore.ContainsKey(searchName))
                {
                    searchBestScore.Add(searchName, 0.0);
                }
                searchBestScore[searchName] = maxResult;
                maxResult = 0.0;
            }



        }
    }
}