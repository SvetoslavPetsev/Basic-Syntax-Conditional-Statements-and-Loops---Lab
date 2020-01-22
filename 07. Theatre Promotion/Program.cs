using System;

namespace _07._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int tiketPrice = 0;
            switch (dayType)
            {
                case "Weekday":
                    if (age >= 0 && age <= 18)
                    {
                        tiketPrice = 12;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        tiketPrice = 18;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        tiketPrice = 12;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                        return;
                    }
                    break;
                case "Weekend":
                    if (age >= 0 && age <= 18)
                    {
                        tiketPrice = 15;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        tiketPrice = 20;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        tiketPrice = 15;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                        return;
                    }
                    break;
                case "Holiday":
                    if (age >= 0 && age <= 18)
                    {
                        tiketPrice = 5;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        tiketPrice = 12;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        tiketPrice = 10;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                        return;
                    }
                    break;
            }
            Console.WriteLine($"{tiketPrice}$");
        }
    }
}
