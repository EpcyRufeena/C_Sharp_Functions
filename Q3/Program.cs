using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            float rectangle = volume_tank();
            Console.WriteLine(rectangle);
        }
        public static float volume_tank()//with RT,No parameter
        {
            Console.WriteLine("Enter the length of the rectangular length");
            float l = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangular height");
            float w = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of the rectangular width");
            float h = float.Parse(Console.ReadLine());//get input from the user
            float rectangle = l * w * h;//process
            return rectangle; //output -return result to user
        }
    }
}
