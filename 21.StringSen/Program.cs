using System;

namespace StringApplication
{

    class StringProg
    {

        static void Main(string[] args)
        {
            string str1 = "This is test";
            string str2 = "This is text";

            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal.");
            }   

            string sen1 = "Joe";
            string sen2 = "Joe";

            if ( String.Compare(sen1, sen2) == 0)
            {
                Console.WriteLine(sen1 + sen2 + " Rachel");
            }
            else
            {
                Console.WriteLine(sen1 + sen2 + " Monica");
            }

            Console.ReadKey();


        }
    }
}