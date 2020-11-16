using System;

namespace EnumApplication
{
    class EnumProgram
    {
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };

        enum Hobies { Reading, Watching, Listening, Drawing };

        static void Main(string[] args)
        {
            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Fri; 
            
            int Hobby1 = (int)Hobies.Reading;
            int Hobby2 = (int)Hobies.Watching;
            int Hobby3 = (int)Hobies.Listening;
            int Hobby4 = (int)Hobies.Drawing;


            Console.WriteLine("Monday: {0}", WeekdayStart);
            Console.WriteLine("Friday: {0}", WeekdayEnd);

            Console.WriteLine("Reading: {0}", Hobby1);
            Console.WriteLine("Watching: {0}", Hobby2);
            Console.WriteLine("Listening: {0}", Hobby3);
            Console.WriteLine("Drawing: {0}", Hobby4);

            Console.ReadKey();
        }
    }
}