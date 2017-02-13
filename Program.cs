using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            //without nested if
            //Console.WriteLine("enter three numbers");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //if ((a>b) && (a>c))
            //    Console.WriteLine("a is the biggest {0} ", a);
            //if ((b>a) && (b>c))
            //    Console.WriteLine("b is the biggest {0} ", b);
            //if ((c>a) && (c>b))
            //    Console.WriteLine("c is the biggest {0} ", c);


            //with nested if
            //Console.WriteLine("enter three numbers");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //if ((a >= b) && (a >= c))
            //    Console.WriteLine("a is the biggest {0} ", a);
            //else
            //    if ((b >= a) && (b >= c))
            //        Console.WriteLine("b is the biggest {0} ", b);
            //    else
            //        if ((c >= a) && (c >= b))
            //            Console.WriteLine("c is the biggest {0} ", c);


            //taking two digit number and print their sum, but make sure they are only two digit = less then 100, greater then 10
            //Console.WriteLine("please enter a two digit number");
            //int theNum = int.Parse(Console.ReadLine());
            //if ((theNum >= 100) || (theNum <= 9))
            //    Console.WriteLine("you are a tembel");
            //else
            //{
            //    int a = (theNum /10);
            //    int b = (theNum % 10);
            //    Console.WriteLine("the sum is {0}", (a+b));
            //}

            //לולאה שתדפיס את הסכום של i
            Console.WriteLine("enter number");
            int myNum = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < myNum ; i++)
            {
                Console.WriteLine("the sum is {0}",sum);
                sum = sum + i;
            }
        }
    }
}
