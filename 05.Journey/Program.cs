﻿using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string holidayType = "";
            double cost = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    cost = budget * 0.3;
                    holidayType = "Camp";
                }
                else if (season == "winter")
                {
                    cost = budget * 0.7;
                    holidayType = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    cost = budget * 0.4;
                    holidayType = "Camp";
                }
                else if (season == "winter")
                {
                    cost = budget * 0.8;
                    holidayType = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                cost = budget * 0.9;
                holidayType = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{holidayType} - {cost:F2}");
        }
    }
}
