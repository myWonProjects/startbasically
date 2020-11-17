using System;

namespace StaticVarApplication
{
    class WhatIsNumber
    {
        public void ThreeDigits()
        {
            Console.WriteLine("This number is a 3 digit number");
        }
        public void TwoDigits()
        {
            Console.WriteLine("This number is a 2 digit number"); 
        }
        public void Number()
        {
            Console.WriteLine("This is a number");
        }
    }
    class StaticTester
    {
        static void Main(string[] args)
        {
            WhatIsNumber t1 = new WhatIsNumber();
           
            int A;
            A =  Convert.ToInt32(Console.ReadLine());

            if ( A >= 100)
            {
                t1.ThreeDigits();
            }
            else if ( A>=10 && A<100)
            {
                t1.TwoDigits();
            }
            else if( A<10)
            {
                t1.Number();
            }


        }
    }
}