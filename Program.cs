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
            Console.WriteLine("enter three numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if ((a>=b) && (a>=c))
                Console.WriteLine("a is the biggest {0} ", a);
            else
                if ((b>=a) && (b>=c))
                    Console.WriteLine("b is the biggest {0} ", b);
                else
                    if ((c>=a) && (c>=b))
                        Console.WriteLine("c is the biggest {0} ", c);

        }
    }
}
