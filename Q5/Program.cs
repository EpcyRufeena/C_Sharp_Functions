using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
           int s= sum(10, 20);
           int d= diff(10,20);
            Console.WriteLine(s);
            Console.WriteLine(d);
           
        }
        public static int sum(int first,int second)
        {

            int sum = first + second;
            int product = first * second;
            return sum;
            return product;
        }
        public static int diff(int first ,int second)
        {
            int difference = Math.Abs(first - second);
            return difference;
        }

           
        }     
    }
}
