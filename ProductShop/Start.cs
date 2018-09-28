using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class Start
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> dataCollection = new Dictionary<string, Dictionary<string, double>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string shop = input[0];
                if (shop == "Revision")
                {
                    break;
                }
                string product = input[1];
                double price = double.Parse(input[2]);
                //
                if (!dataCollection.ContainsKey(shop))
                {
                    dataCollection.Add(shop, new Dictionary<string, double>());
                }
                if (!dataCollection[shop].ContainsKey(product))
                {
                    dataCollection[shop].Add(product, 0.0);
                }
                dataCollection[shop][product] = price;
            }

            foreach (var brand in dataCollection.OrderBy(x => x.Key))
            {
                Console.WriteLine(brand.Key+"->");
                foreach (var product in brand.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
