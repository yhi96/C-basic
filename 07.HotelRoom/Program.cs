using System.Diagnostics.CodeAnalysis;

namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            if ((month == "May" || month == "October") && nights > 7 && nights < 14)
            {
                studioPrice = 50 * nights * 0.95; //5% discount
                apartmentPrice = 65 * nights;
            }
            else if ((month == "May" || month == "October") && nights > 14)
            {
                studioPrice = 50 * nights * 0.70; //30% discount
                apartmentPrice = 65 * nights * 0.90; //10% discount
            }
            else if ((month == "June" || month == "September"))
                if (nights > 14)
            {
                studioPrice = 75.20 * nights * 0.80; //20% discount
                apartmentPrice = 68.70 * nights * 0.90; //10% discount
            }
            else
                {
                    studioPrice = 75.20 * nights;
                    apartmentPrice = 68.70 * nights;
                }
            else if ((month == "July" || month == "August") && nights > 14)
            {
                studioPrice = 76 * nights;
                apartmentPrice = 77 * nights * 0.90; //10% discount
            }
            else if ((month == "July") || month == "August" && nights <= 14)
            {
                studioPrice = 76 * nights;
                apartmentPrice = 77 * nights;
            }
            Console.WriteLine($" Apartment: {apartmentPrice:F2} lv.");
            Console.WriteLine($" Studio: {studioPrice:F2} lv.");

        }
    }
}