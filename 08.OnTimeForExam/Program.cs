using System.ComponentModel.Design;
using System;

namespace OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMinute;
            int arrivalTime = arrivalHour * 60 + arrivalMinute;

            if (arrivalTime > examTime)
            {
                Console.WriteLine("Late");
                int minutesLate = arrivalTime - examTime;
                if (minutesLate >= 60)
                {
                    int hoursLate = minutesLate / 60;
                    int remainingMinutes = minutesLate % 60;
                    Console.WriteLine($"{hoursLate}:{remainingMinutes:D2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{minutesLate} minutes after the start");
                }
            }
            else if (arrivalTime <= examTime && examTime - arrivalTime <= 30)
            {
                Console.WriteLine("On time");
                int minutesEarly = examTime - arrivalTime;
                if (minutesEarly != 0)
                {
                    Console.WriteLine($"{minutesEarly} minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Early");
                int minutesEarly = examTime - arrivalTime;
                if (minutesEarly >= 60)
                {
                    int hoursEarly = minutesEarly / 60;
                    int remainingMinutes = minutesEarly % 60;
                    Console.WriteLine($"{hoursEarly}:{remainingMinutes:D2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{minutesEarly} minutes before the start");
                }
            }
        }
    }
}
