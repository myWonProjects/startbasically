using System;

namespace VariableDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            short a;
            int b;
            double c;

            /* actual initialization */
            a = 10;
            b = 20;
            c = a + b;

            string x;
            string y;
            int z;
            x = "aysenur";
            y = "bhcvn";

            //z = (int)x + (int)y;     we cannot string to int

            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            Console.WriteLine("Ad: {0}, Soyad:{1}", x, y);
            Console.ReadLine();


        }
    }
}