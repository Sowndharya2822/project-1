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
            q2();
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
            float value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the power");
            float power = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(value1,power));
        }


    }
}
