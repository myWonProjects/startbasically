using System;

namespace StringApplication
{

    class Program
    {

        static void Main(string[] args)
        {
            //from string literal and string concatenation
            string fname, lname;
            fname = "Ayşenur";
            lname = " Bhcvn";

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string[] sarray = { "Hello", "From", "Tutorials", "Point" };
            string[] toDo = { "String", "Enums", "Inheritance", "Structure" };
            char[] whatsUp = { 'W', 'H', 'A', 'T', 'S', 'U', 'P' };

            string fullname = fname + lname;
            Console.WriteLine("Full Name: {0}", fullname);

            //by using string constructor { 'H', 'e', 'l', 'l','o' };
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);

            string whats = new string(whatsUp);
            Console.WriteLine("{0}", whats);

            
            //methods returning string { "Hello", "From", "Tutorials", "Point" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);

            string toDoList = string.Join(" ", toDo);
            Console.WriteLine("To Do List : {0}", toDoList);

            //formatting method to convert a value
            DateTime waiting = new DateTime(2020, 11, 16, 11, 18, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);
        }
    }
}