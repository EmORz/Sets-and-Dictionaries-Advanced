using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var nClouths = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < nClouths; i++)
            {
                string[] parts = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = parts[0];
                string[] temp = parts[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (!data.ContainsKey(color))
                {
                    data.Add(color, new Dictionary<string, int>());
                }


                if (temp.Count() > 0)
                {
                    for (int k = 0; k < temp.Length; k++)
                    {
                        if (!data[color].ContainsKey(temp[k]))
                        {
                            data[color].Add(temp[k], 0);
                        }
                        data[color][temp[k]]++;
                    }
                }



            }
            string[] searched = Console.ReadLine().Split();
            if (data.Count > 0)
            {
                foreach (var color in data)
                {
                    Console.WriteLine($"{color.Key} clothes:");


                    if (color.Key.Contains(searched[0]))
                    {

                        foreach (var clouths in color.Value)
                        {
                            if (clouths.Key == searched[1])
                            {
                                Console.WriteLine("* " + clouths.Key + " - {0} (found!)", clouths.Value);


                            }
                            else
                            {
                                Console.WriteLine("* " + clouths.Key + " - {0}", clouths.Value);

                            }

                        }
                    }
                    else
                    {
                        foreach (var clouths in color.Value)
                        {
                            Console.WriteLine("* " + clouths.Key + " - {0}", clouths.Value);
                        }
                    }


                }
            }

        }
    }
}
