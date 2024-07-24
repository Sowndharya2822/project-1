using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            q9();
        }
        public static void q1()
        {
            Console.WriteLine("enter the number1");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the numbeer2");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(number1+number2);
            Console.WriteLine(number1-number2);
            Console.WriteLine(number1*number2);
        }
        public static void q2()
        {
            Console.WriteLine("enter the value1"); 
          double value1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the power");
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(value1, power));
        }
        public static void q3()
        {
            Console.WriteLine("enter the leanth");
            int  leanth = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the width");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the hight");
            int hight = int.Parse(Console.ReadLine());
            Console.WriteLine("the value of rectangular is");
            Console.WriteLine(leanth*width*hight);
        }
        public static void q4()
        {
            Console.WriteLine("enter the radius");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine(2*Math.PI*r);
        }
        public static void q5()
        {
            Console.WriteLine("enter the numerater");
            int numerater = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the denominator");
            int denominater = int.Parse(Console.ReadLine()); 
            int quotient = numerater / denominater;
            int remainter = numerater % denominater;
            Console.WriteLine("quotieent is"+quotient);
            Console.WriteLine("remainter"+remainter);
        }
        public static void q6()
        {
            Console.WriteLine("enter the square value");
            int square = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(square,2));
        }
        public static void q7()
        {
            Console.WriteLine("enter square root value");
            int square = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(square));
        }
        public static void q8()
        {
            Console.WriteLine("enter the base of triangle:");
            double baseoftriangle = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the hight of triangle:");
            double hightoftriangle = double.Parse(Console.ReadLine());
            Console.WriteLine(1.0/2*(baseoftriangle*hightoftriangle));
        }
        public static void q9()
        {
            Console.WriteLine("enter the convert kilomiter to miles");
            double kilomiter = Convert.ToDouble(Console.ReadLine());
            double miles = kilomiter* 0.6;
            Console.WriteLine("miles:"+miles);
        }
        public static void q10()
        {
            Console.WriteLine("enter the convert to celsius fahrenheit:");
            double celsius = double.Parse(Console.ReadLine());
            Console.WriteLine(celsius*9.0/5+32);
        }
        public static void q11()
        {
            Console.WriteLine("swap variable:");
            int a = 30;
            int b = 40;
            int temporary = a;
            a = b;
            b = temporary;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        public static void q12()
        {
            Console.WriteLine("swap variable without use temporary");
            int x = 100;
            int y = 200;

            x = x + y;
            y = y - x;
            x = x - y;

            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        public static void q13()
        {
            Console.WriteLine("swap varible without causing overflow");
            int m = 600;
            int s = 500;

            m = m ^ s;
            s = s ^ m;
            s = m ^ s;

            Console.WriteLine(m);
            Console.WriteLine(s);
        }
        public static void q14()
        {
            Console.WriteLine("generate the random number");
            Random r = new Random();
            Console.WriteLine(r.Next());
        }
        public static void q15()
        {
            Console.WriteLine("area of a field in acres");
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine(length*width/43560);
        
        
        
        }

































    }
}
