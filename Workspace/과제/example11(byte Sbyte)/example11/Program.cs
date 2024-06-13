using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 255;
            sbyte b = ((sbyte)a);


            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);

            b = -10;
            a = (byte)b;

            Console.WriteLine("b : " + b);
            Console.WriteLine("a : " + a);

            Console.ReadLine();

        }
    }
}
