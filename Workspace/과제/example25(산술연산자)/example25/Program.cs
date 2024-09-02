using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a ,b, c = 0;
            float d;
            double e;

            a = 111 + 222;
            Console.WriteLine("111+222 = " + a);
            a = 222 - 111;
            Console.WriteLine("111-222 = " + a);
            b = 22 * 25;
            Console.WriteLine("22 * 25 = " + b);
            c = 32 / 7;
            Console.WriteLine("32/7 = " + c);
            d = 32.0f / 7;
            Console.WriteLine("32/7 = " + d);
            e = 32.0d / 7;
            Console.WriteLine("32/7 = " + e);



            Console.ReadLine();
        }
    }
}
