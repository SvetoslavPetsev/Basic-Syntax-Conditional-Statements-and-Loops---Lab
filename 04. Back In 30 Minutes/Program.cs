using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int all = hours * 60 + minutes;
            int allWithWaiting = all + 30;

            int newHour = allWithWaiting / 60;
            int newMinutes = allWithWaiting % 60;

            if (newHour > 23)
            {
                newHour -= 24;
            }
            Console.WriteLine($"{newHour}:{newMinutes:D2}");
        }
    }
}
