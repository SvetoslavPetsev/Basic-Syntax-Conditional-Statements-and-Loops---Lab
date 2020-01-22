using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int numberN = 0;
            int counterOdd = 0;
            int sumoddNumbers = 0;

            while (counterOdd < numbers)
            {
                if (numberN % 2 != 0)
                {
                    int oddNumber = numberN;
                    Console.WriteLine(oddNumber);
                    counterOdd++;
                    sumoddNumbers += oddNumber;
                }
                numberN++;
            }
            Console.WriteLine($"Sum: {sumoddNumbers}");
        }
    }
}
