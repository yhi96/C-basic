namespace _09.SkiHoliday
{
    namespace _09.SkiHoliday
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int days = int.Parse(Console.ReadLine());
                string roomType = Console.ReadLine();
                string assessment = Console.ReadLine();

                double price = 0;
                int nights = days - 1;


                if (roomType == "room for one person")
                {
                    price = nights * 118.00;
                }

                else if (roomType == "apartment")
                {
                    double basePrice = nights * 155.00;
                    if (days < 10)
                    {
                        price = basePrice * 0.70;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        price = basePrice * 0.65;
                    }
                    else if (days > 15)
                    {
                        price = basePrice * 0.50;
                    }
                }
                else if (roomType == "president apartment")
                {
                    double basePrice = nights * 235.00;
                    if (days < 10)
                    {
                        price = basePrice * 0.90;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        price = basePrice * 0.85;
                    }
                    else if (days > 15)
                    {
                        price = basePrice * 0.80;
                    }
                }
                if (assessment == "positive")
                {
                    price = price * 1.25;
                }
                else if (assessment == "negative")
                {
                    price = price * 0.90;
                }
                Console.WriteLine($"{price:F2}");
            }
        }
    }