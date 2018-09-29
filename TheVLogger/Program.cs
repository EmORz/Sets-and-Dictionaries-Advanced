using System;
using System.Collections.Generic;

namespace TheVLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var data = new Dictionary<string, Dictionary<string, int>>();

            while (input != "Statistics")
            {
                string[] elements = Console.ReadLine().Split();
                string name = elements[0];
                string command = elements[1];

                if (command == "joined")
                {
                    if (!data.ContainsKey(name))
                    {
                        data[name]["followers"] = 0;
                        data[name]["following"] = 0;
                    }
                }
                if (command == "followed")
                {
                    string vlogerName = elements[2];
                    if (name!=vlogerName)
                    {

                    }
                }




                input = Console.ReadLine();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
