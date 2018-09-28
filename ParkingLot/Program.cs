using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> dataForCars = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "END")
            {

                string[] parts = input.Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0];
                string carNUmber = parts[1];
                //
                switch (command)
                {
                    case "IN":
                        dataForCars.Add(carNUmber);
                        break;
                    case "OUT":
                        dataForCars.Remove(carNUmber);
                        break;
                }
                input = Console.ReadLine();
            }
            if (dataForCars.Count>0)
            {
                Console.WriteLine(string.Join("\n", dataForCars));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
