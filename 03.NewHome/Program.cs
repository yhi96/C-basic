namespace _03.NewHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double cost = 0;

            if (flowers == "Roses")
            {
                cost = count * 5.00;
                if (count > 80)
                {
                    cost = cost * 0.9;
                }

            }
            else if (flowers == "Dahlias")
            {

                cost = count * 3.80;
                if (count > 90)
                {
                    cost = cost * 0.85;
                }

            }
            else if (flowers == "Tulips")
            {
                cost = count * 2.80;
                if (count > 80)
                {
                    cost = cost * 0.85;
                }
            }
            else if (flowers == "Narcissus")
            {
                cost = count * 3.0;
                if (count < 120)
                {
                    cost = cost * 1.15;
                }
            }
            else if (flowers == "Gladiolus")
            {
                cost = count * 2.50;
                if (count < 80)
                {
                    cost = cost * 1.2;
                }
            }
            if (budget < cost)
                Console.WriteLine($"Not enough money, you need {(cost - budget):F2} leva more.");
            else
                Console.WriteLine($"Hey, you have a great garden with {count} {flowers} and {(budget - cost):F2} leva left.");
        
        
        }


    }
}