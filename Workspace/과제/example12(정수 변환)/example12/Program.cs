using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 255;
            int b;
            b = a;

            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);

            int c = 700;
            byte d;
            d = (byte)c;
            Console.Write("\n");
            Console.WriteLine("c : " + c);
            Console.WriteLine("d : " + d);

            Console.ReadLine();
        }
    }
}
