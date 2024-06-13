using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 32.12345f;
            double b;
            b = a;

            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);
            Console.Write("\n");

            double c = 2.123456789012345;
            float d  = (float)c;

            Console.WriteLine("c : " + c);
            Console.WriteLine("d : " + d);

            Console.ReadLine();
        }
    }
}
