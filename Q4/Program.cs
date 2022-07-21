using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            double perimeter = perimeter_circle();
            Console.WriteLine(perimeter);
        }
        public static double perimeter_circle()
        {
            double pi = 3.14;
            Console.WriteLine("Enter the radius");
            double radius = Convert.ToDouble(Console.ReadLine());

            double perimeter = 2 * pi * radius;
            return perimeter;
        }
    }
}
