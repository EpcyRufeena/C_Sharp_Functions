using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int s = GetInteger("Enter a number");
            //int random = random_num(s);                   //Q16
            //Console.WriteLine("Random number is :" +random);
            //double squart = sqrt(s);                       //Q7
            //Console.WriteLine("square root of number is :" +squart);
            //int d = GetInteger("Enter a number");  
            //int e = GetInteger("Enter a ");           //Q17
            //int avg = average(s, d, e);
            //Console.WriteLine("Average is :"+avg);
            //Console.WriteLine("average Value is :" +avg);
            //int x = sum(s,d);                              //Q1
            //int y = product(s,d);
            //int square = product(s, d);
            //Console.WriteLine("Square value is :"+square);  //Q6
            //int z = diff(s,d);
            //Console.WriteLine("sum value is:" +x);  //Q1
            //Console.WriteLine("product value is:" +y);
            //Console.WriteLine("difference value is:" +z); 
            //double x = GetDouble("Enter a number");        //Q2 &Q8 &Q9 &Q10 //Q23 //Q20
            //height(x);                                       //Q23
            //double celcius = cel_farenheit(x); //Q10
            //Console.WriteLine("celcius to fahrenheit :"+celcius);
            //double mile = km_mile(x);                           //Q9
            //Console.WriteLine("km to mile is:" +mile);
            //double y = GetDouble("Enter a number");
            //double z = GetDouble("Enter a number");
            //height(y,z);                                        //Q24         
            //double gpay = gross_pay(x, y, z);    //Q20
            //Console.WriteLine("Grosspay is:"+gpay);         
            //double area_field = area(x, y);   //Q15
            //Console.WriteLine("area of a field is :" +area_field);
            //double triangle =area_triangle(x, y); //Q8
            //Console.WriteLine("Area of a triangle is :"+triangle);
            //double power = powervalue(x, y);
            //Console.WriteLine("power value is:" +power );  //Q2
            //float radius = GetFloat("Enter radius");        //Q4
            //float pm=perimeter_radius(radius);
            //Console.WriteLine("perimeter of a circle :"+pm);
            //float x = GetFloat("Enter a number");          //Q3
            //float y = GetFloat("Enter a number ");
            //float quot = quotient(x, y);                //Q5
            //float rem = remainder(x, y);
            //Console.WriteLine("Quotient value is :"+quot+"Remainder value is :"+rem);
            //float volume = volumerectang(l, w, h);
            //Console.WriteLine("volume of a tank is :" +volume);
            //random();   //Q14
            //int bill = GetInteger("Enter a bill amount");      //Q18
            //double tips = bill_amount(bill);
            //Console.WriteLine("tips amount is :" +tips); 
            //int amount = GetInteger("Enter a amount");       //Q19
            //float tax = GetFloat("Enter a tax percentage");
            //double netamount = tax_percent(amount, tax);
            //Console.WriteLine("net amount is :"+netamount);
            //int basic_salary = GetInteger("Enter Basic salary :");   //Q20
            //float DA = GetFloat("Enter dearness allowence");
            //float Ta = GetFloat("Enter travel allowence");
            //float grosspay=gross_pay(basic_salary,DA,Ta);
            //double p=GetDouble("Enter principal amount");  //Q21 &Q22
            //double n=GetDouble("Enter number of time ");
            //double r=GetDouble("Enter interest rate");
            //double t = GetDouble("Enter time period");
            //double Interest = interest(p, n, r,t);
           // Console.WriteLine("simple interest is :"+simpleinterest);  
            //Console.WriteLine("Compound interest is :"+Interest);
        }
        public static int sum(int first, int second)       //Q1
        {
            int sum = first + second;            
            return sum;      
        }       
        public static int product(int first, int second)   //Q1 & Q6
        {
            int product = first * second;
            return product;
        }
        public static int diff(int first, int second)
        {
            int difference = Math.Abs(first - second);
            return difference;
        }                                             
        public static double powervalue(double b,double e)  //Q2
        {
            double n = Math.Pow(b,e);
            return n;                                 
        }              
        public static float volumerectang(float l, float w, float h) //Q3
        {
            float volume = l * w * h;
            return volume;                                          
        }
        public static float perimeter_radius(float radius)   //Q4
        {
            double pi =(float) 3.14;
            double perimeter = 2 * pi * radius;
            return (float)perimeter;
        }
        public static float quotient(float num, float denom) //Q5
        {
            float quot = num / denom;
            return quot;
        }
        public static float remainder(float num, float denom)
        {
            float remain = num % denom;
            return remain;
        }
        public static double sqrt(int a)                 //Q7
        {
            double squart = Math.Sqrt(a);
            return squart;
        }
        
        public static double area(double length, double width)  //Q8 &Q15
        {
            //double triangle = (1 / 2.0 * (b * h));
            //return triangle;
            double area = length * width;
            return area;
        }
        public static double km_mile(double km)      //Q9
        {
            double miles = km / 1.60934;
            return miles;
        }
        public static double cel_farenheit(double celcius )    //Q10
        {
            double Fahrenheit = (celcius * 9 / 5) + 32;
            return Fahrenheit;
        }
        public static void random()                           //Q14
        { 
            Random r=new Random();
            int num1 = r.Next(1, 101);
            Console.WriteLine(num1);
        }
        public static int random_num(int n)           //Q16
        {
            int random = n * (n + 1) / 2;
            return random;
        }
        public static int average(int a, int b, int c) //Q17 &25
        {
            int total = a + b + c;
            Console.WriteLine("Total marks :"+total);
            int average = total / 3;            
            return average;
        }
        public static double bill_amount(double amount)  //Q18
        {
            double tips = (amount * (5 / 100.0));
            return tips;
        }
        public static double tax_percent(int amount, float tax)  //Q19
        {
            double netamount = (amount / (1 + tax / 100));
            return netamount;
        }
        public static double gross_pay( double basicpay,double da, double ta)  //Q20
        {
            double pf = (basicpay*8.0 / 100);
            double Grosspay = basicpay + da + ta - pf;
            return Grosspay;                               
        }
        public static double interest(double p, double n, double r,double t) //Q21 & Q22
        {
            //double simple_interest = (p * n * r) / 100;
            //return simple_interest;
            double Compound = p * Math.Pow(1 + r / (100 * n), n * t);
            return Compound;
        }
        public static void height(double height,double weight)         //Q23 //24
        {           
            //double inch = height/ 2.54;
            //Console.WriteLine("height in inch is :"+inch);
            //double feet = height * 0.3048;
            //Console.WriteLine("height in feet is :"+feet);
             double h = (height /39.37); //1meter=39.37 inches
             Console.WriteLine("height in meters"+h);
             double kg = (weight * 1000);
             Console.WriteLine("weight in kilogram"+kg);
             double bmi = ((weight / height) * height);           
        }        
        public static int GetInteger(string message)  //Integer
        {
            Console.WriteLine(message);
            int temp = int.Parse(Console.ReadLine());
            return temp;
        }
        public static double GetDouble(string message)   //Double
        { 
            Console.WriteLine(message);
            double temp = double.Parse(Console.ReadLine());
            return temp;
        }
        public static float GetFloat(string message)     //float
        {
            Console.WriteLine(message);
            float temp = float.Parse(Console.ReadLine());
            return temp;
        }
    }
}
