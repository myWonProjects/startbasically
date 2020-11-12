using System;

namespace _14.FindMaxinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0, min = 0, number;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Enter {0}. number ", i);
                number = Convert.ToInt32(Console.ReadLine());
                if (i == 1)
                {
                    max = number;
                    min = number;
                }
                if (min > number)
                { min = number; }
                if (max < number)
                { max = number; }

            }

            Console.WriteLine("Max number {0}:", max);
            Console.WriteLine("Min number {0}:", min);
            Console.ReadKey();
        }
    }

}

