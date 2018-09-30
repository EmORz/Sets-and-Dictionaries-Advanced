using System;
using System.Collections.Generic;
using System.Linq;

namespace TheVLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var data = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            while (input != "Statistics")
            {
                string[] elements = input.Split(" ");
                string name = elements[0];
                string command = elements[1];
                string vlogerName = elements[2];

                if (command == "joined")
                {
                    if (!data.ContainsKey(name))
                    {
                        data.Add(name, new Dictionary<string, SortedSet<string>>());
                        data[name].Add("followers", new SortedSet<string>());
                        data[name].Add("following", new SortedSet<string>());

                    }

                }
                else if (command == "followed")
                {
                    if (data.ContainsKey(name)&&data.ContainsKey(vlogerName) && name!=vlogerName)
                    {
                        data[name]["following"].Add(vlogerName);
                        data[vlogerName]["followers"].Add(name);
                    }
                }

                input = Console.ReadLine();
            }
            var count = data.Keys.Count;
            var text = $"The V-Logger has a total of {count} vloggers in its logs.";           
            Console.WriteLine(text);
            var orderByDescending = data.OrderByDescending(x => x.Value["followers"].Count).ThenBy(x => x.Value["following"].Count);
            int counter = 1;
            foreach (var item in orderByDescending)
            {

                Console.WriteLine($"{counter}. {item.Key} : {item.Value["followers"].Count} followers, {item.Value["following"].Count} following");
                if (counter == 1)
                {
                    foreach (var man in item.Value["followers"])
                    {
                        Console.WriteLine($"*  {man}");
                    }
                }
                counter++;             
            }
        }
    }
}
