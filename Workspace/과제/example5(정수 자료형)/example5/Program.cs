using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            byte c = 30;
            sbyte d = 0;


            a = 257;
            d = (sbyte)c;
            c = (byte)a;

            Console.WriteLine("a = " + a );
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.Read();
        }
    }
}
