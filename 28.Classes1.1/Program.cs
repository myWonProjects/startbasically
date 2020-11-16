using System;

namespace PersonApplication
{
    class Person      //this class contains personality traits
    {
        public string name;
        public int age;
        public string job;
        public string gender;
        public string trait;

    }

    class Movies     //this class contains sth about movies
    {
        public string name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person Person1 = new Person();
            Person Person2 = new Person();

            Movies Movie1 = new Movies();


            // person 1 specification
            Person1.name = "Joe Tribbiani";
            Person1.age = 30;
            Person1.job = "Actor";
            Person1.gender = "Male";
            Person1.trait = "He loves sandwitches";

            //  person 2 specification
            Person2.name = "Monica Geller";
            Person2.age = 30;
            Person2.job = "Chef";
            Person2.gender = "Female";
            Person2.trait = "She loves cleaning";

            //a movie specification
            Movie1.name = "Friends";

            Console.WriteLine("First Person : {0}, {1}, {2}, {3}, {4}, The series he played : {5}", Person1.name, Person1.age, Person1.job, Person1.gender, Person1.trait, Movie1.name);

            Console.WriteLine("Second Person : {0}, {1}, {2}, {3}, {4}, The series she played : {5}", Person2.name, Person2.age, Person2.job, Person2.gender, Person2.trait, Movie1.name);
            Console.ReadKey();






        }
    }
}
