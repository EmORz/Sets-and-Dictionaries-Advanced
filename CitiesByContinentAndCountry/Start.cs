using System;
using System.Collections.Generic;

namespace CitiesByContinentAndCountry
{
    class Start
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> dataCollection = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < number; i++)
            {
                string[] infoInput = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string continent = infoInput[0];
                string country = infoInput[1];
                string cities = infoInput[2];
                //
                if (!dataCollection.ContainsKey(continent))
                {
                    dataCollection.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!dataCollection[continent].ContainsKey(country))
                {
                    dataCollection[continent][country]= new List<string>();
                }
                dataCollection[continent][country].Add(cities);
            }
            foreach (var continents in dataCollection)
            {
                Console.WriteLine(continents.Key+":");
                foreach (var country in continents.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }

            }
        }
    }
}
