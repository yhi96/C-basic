namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double price = 0;

            switch (season)
            {
                case "Spring": price = 3000; break;
                case "Summer": price = 4200; break;
                case "Autumn": price = 4200; break;
                case "Winter": price = 2600; break;
            }
            if (count <= 6)
                price = price * 0.9;
            else if (count >= 7 && count <= 11)            
                price = price * 0.85;           
            else if (count >= 12)           
                price = price * 0.75;           

            if (count % 2 == 0 && season != "Autumn")
            {
                price = price * 0.95;
            }
            if (price <= budget)
                Console.WriteLine($"Yes! You have {(budget - price):F2} leva left.");
            else
                Console.WriteLine($"Not enough money! You need {(price - budget):F2} leva.");
        }
    }
}