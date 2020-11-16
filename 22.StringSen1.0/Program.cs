using System;

namespace StringApplication
{

    class StringProg
    {

        static void Main(string[] args)
        {
            string str = "This is test";

            if (str.Contains("test"))
            {
                Console.WriteLine("The sequence 'test' was found.");
            }

            string sen = "I love Friends";
            string sen2 = "No way! You couldn't have watched this series";
            
            if (sen.Contains("Friends"))
            {
                Console.WriteLine("In this sentence is about 'Friends'");
            }

            if (sen2.Contains("Friends"))
            {
                Console.WriteLine("In this sentence is about 'Friends'");
            }
            else
            {
                Console.WriteLine("In this sentence is about 'Nothing'");
            }

            Console.ReadKey();
        }    
    }
}