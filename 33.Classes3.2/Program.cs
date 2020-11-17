using System;

namespace LineApplication
{
    class Factorial
    {
        private double n;
        public double result;

        public Factorial(double n)
        {

            if (n == 1)
            {
                n = 1;
                result = 1;
                
            }
            else
            {
                n = 6;
                result = (n - 1) * n;
                
            }
            
        }
       
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial(6.0);

            Console.WriteLine(" FACTORIAL OF NUMBER {0} = {1}", factorial.n , factorial.result);

            Console.ReadKey();
        }
    }
}