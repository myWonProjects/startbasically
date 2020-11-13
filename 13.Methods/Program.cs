using System;

namespace CalculatorApplication
{
    class NumberManipulator
    {
        public int FindMax(int num1, int num2)
        {
            /* local variable declaration */
            int result;

            if (num1 > num2)
            {
                result = num1;
                return result;
            }
            else if (num1 < num2)
            {
                result = num2;
                return result;
            }
            else
            {
                Console.WriteLine("They are equall");
                result=0;
                return result;
            }
        }

        static void Main(string[] args)
        {
            /* local variable definition */
            int a;
            int b;
            int ret;
            NumberManipulator n = new NumberManipulator();

            Console.WriteLine("Enter a number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            b = Convert.ToInt32(Console.ReadLine());
            //calling the FindMax method
            ret = n.FindMax(a, b);
            Console.WriteLine("Max value is : {0}", ret);
            Console.ReadLine();
        }
    }
}