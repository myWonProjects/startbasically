using System;

namespace GerVoltage
{
    class Program
    {
        static void Main(string[] args)
        {
            double i;
            double r;

            Console.WriteLine("Enter Current Value: ");
            i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Resistance Value: ");
            r = Convert.ToDouble(Console.ReadLine());

            double v = i * r;
            Console.WriteLine("Current: {0}, Resistance: {1}, Voltage: {2}", i, r, v);
            Console.ReadLine();
        }
    }
}
