using System;

namespace StringApplication
{

    class StringProg
    {

        static void Main(string[] args)
        {
            string str = "Last night I dreamt of San Pedro";
            Console.WriteLine(str);
            string substr = str.Substring(23);
            Console.WriteLine(substr);

            string sen = "Joe doesn't share his food";
            Console.WriteLine(sen);
            string subsen = sen.Substring(23);
            Console.WriteLine(subsen);

            string[] starray = new string[]{"There is a where but everywhere is a trap",
            "There is one more way but back is banned",
            "far from the world near the sea"};

            string sen2 = String.Join("\n", starray);
            Console.WriteLine(sen2);
        }
    }
}