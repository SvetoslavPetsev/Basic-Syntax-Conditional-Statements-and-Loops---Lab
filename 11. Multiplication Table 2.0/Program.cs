using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());
            int multip;
            if (area <= 10)
            {
                for (int i = area; i <= 10; i++)
                {
                    multip = n * i;
                    Console.WriteLine($"{n} X {i} = {multip}");
                }
            }
            else
            {
                multip = n * area;
                Console.WriteLine($"{n} X {area} = {multip}");
            }
        }
    }
}
