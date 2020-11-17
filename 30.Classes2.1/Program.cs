using System;

namespace TriangleApplication
{
    class Triangle
    {
        private double a;    //edges of triangles
        private double b; 
        private double c;
        private double height;
        private double weight;

        public void setEdges(double edge1,double edge2, double edge3,double edge4,double edge5)
        {
            a = edge1;
            b = edge2;
            c = edge3;
            height = edge4;
            weight = edge5;
        }
       
        public double setCircle()
        {
            return a + b + c ;
        }

        public double setArea()
        {
            return (height * weight) / 2;
        }
      
    }
    class Boxtester
    {
        static void Main(string[] args)
        {
            Triangle tri1 = new Triangle();    // Declare tri1
            Triangle tri2 = new Triangle();

            double resultCircle;   //it result of triangle's circle
            double resultArea;     //it result of triangle's area

           
            tri1.setEdges(3.0, 4.0, 5.0, 4.0, 8.0);   //we send all size of triagles with a func.
            

            resultCircle = tri1.setCircle();         //we calculate circle but this func. is in class triangle
            resultArea = tri1.setArea();

            Console.WriteLine("RESULT -> Circle: {0} Area: {1}",resultCircle, resultArea);


            Console.ReadKey();
        }
    }
}