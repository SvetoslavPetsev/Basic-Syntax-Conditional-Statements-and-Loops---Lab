using System;

namespace _06._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string countryName = Console.ReadLine();
            string speak;
            switch (countryName)
            {
                case "USA":
                case "England":
                    speak = "English";
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    speak = "Spanish";
                    break;
                default:
                    speak = "unknown";
                    break;
            }
            Console.WriteLine($"{speak}");
        }
    }
}
