using System;

namespace _17.Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] n = new int[5,5]; /* n is an array of 10 integers */
            int i, j;

            /* initialize elements of array n */
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.Write(n[i, j] + "*");
                    Console.WriteLine("*", n[i, j]);
                }

                Console.WriteLine();
            }

        }
    }
}
