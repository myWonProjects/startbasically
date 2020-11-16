using System;

namespace BoxApplication
{
    class Quadrilateral        //this class is about 4 edges of shape
    {
        private double shortEdge;  
        private double longEdge;

        public int ShortEdge
        {
            get { return shortEdge; }
            set { shortEdge = value; }
        }

        public int LongEdge
        {
            get { return longEdge; }
            set { longEdge = value; }
        }
        public string Type
        {
            get
            {
                string type = "";
                if (shortEdge == longEdge)
                    type = "Square";
                else
                    type = "Rectangle";
                return type;
            }
        }
    }
    class Boxtester
    {
        static void Main(string[] args)
        {
            Quadrilateral shape = new Quadrilateral();
            shape.longEdge = 100;
            shape.shortEdge = 100,

            Console.WriteLine("{0}x{1}",
            dortgen.ShorEdge, dortgen.LongEdge);
            Console.WriteLine("{0}", dortgen.Type);


        }
    }
}