using System;

namespace _19.AnotherArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[10, 10];

           

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(m[i, j] + "*");
                    Console.WriteLine("{0}", m[i, j]);
                    Console.WriteLine("*\t", j);
                    
                }

               
                Console.WriteLine();

            }
            

            

        }
    }
}
