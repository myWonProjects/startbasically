using System;

struct MyFavouriteFilms
{
    public string name;
    public string created_by;
    public string stars;
    public string subject;
    public int film_id;
};

public class testStructure
{
    public static void Main(string[] args)
    {
        MyFavouriteFilms Film1;   
        MyFavouriteFilms Film2;  

        
        Film1.name = "Interstaller";
        Film1.created_by = "Christopher Nolan";
        Film1.stars = "Matthew McConaughey";
        Film1.subject = "Science-Fiction";
        Film1.film_id = 01;

       
        Film2.name = "LOR";
        Film2.created_by = "Peter Jackson";
        Film2.stars = "Elijah Wood";
        Film2.subject = "Fantastic";
        Film2.film_id = 02;

        int[,] n = new int[1, 2]; /* n is an array of 10 integers */
        int i, j;

        for (i = 0; i < 1; i++)
        {
            for (j = 0; j < 1; j++)
            {
                Console.WriteLine(" {0}", Film1.film_id);
                Console.WriteLine(" {0}", Film1.name);
                Console.WriteLine(" {0}", Film1.created_by);
                Console.WriteLine(" {0}", Film1.stars);
                Console.WriteLine(" {0}", Film1.subject);


                Console.WriteLine(" {0}", Film2.film_id);
                Console.WriteLine(" {0}", Film2.name);
                Console.WriteLine(" {0}", Film2.created_by);
                Console.WriteLine(" {0}", Film1.stars);
                Console.WriteLine(" {0}", Film2.subject);
            }

            Console.WriteLine();
        }

        /*
        Console.WriteLine(" {0}", Film1.film_id);
        Console.WriteLine(" {0}", Film1.name);
        Console.WriteLine(" {0}", Film1.created_by);
        Console.WriteLine(" {0}", Film1.stars);
        Console.WriteLine(" {0}", Film1.subject);


        Console.WriteLine(" {0}", Film2.film_id);
        Console.WriteLine(" {0}", Film2.name);
        Console.WriteLine(" {0}", Film2.created_by);
        Console.WriteLine(" {0}", Film1.stars);
        Console.WriteLine(" {0}", Film2.subject); */
        

        Console.ReadKey();
    }
}