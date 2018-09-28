using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> listOfVIP = new HashSet<string>();
            HashSet<string> listOfNormal = new HashSet<string>();
            string[] numArr = { "0", "1", "2", "3", "4", "5","6", "7", "8", "9"};
           
            string input = Console.ReadLine();

            while (input != "PARTY")
            {
                var testForNum = input[0].ToString();
                if (numArr.Contains(testForNum))
                {
                    listOfVIP.Add(input);
                }
                else
                {
                    listOfNormal.Add(input);
                }
                input = Console.ReadLine();
            }

            while (input != "END")
            {

                var testForNum = input[0].ToString();
                if (numArr.Contains(testForNum))
                {
                    listOfVIP.Remove(input);
                }
                else
                {
                    listOfNormal.Remove(input);
                }
                input = Console.ReadLine();
            }
            var countGuestThatAreOut = listOfVIP.Count + listOfNormal.Count;
            Console.WriteLine(countGuestThatAreOut);
            if (listOfVIP.Count>0)
            {
                Console.WriteLine(string.Join("\n", listOfVIP));
            }
            if (listOfNormal.Count > 0)
            {
                Console.WriteLine(string.Join("\n", listOfNormal));
            }



        }
    }
}
