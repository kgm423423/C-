using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 30, c = 12, result;

            Console.WriteLine("a = " + Convert.ToString(a, 2).PadLeft(8, '0'));
            result = a << 1;
            Console.WriteLine("r = " + Convert.ToString(result, 2).PadLeft(8, '0'));
            result = a << 2;
            Console.WriteLine("r = " + Convert.ToString(result, 2).PadLeft(8, '0'));
            Console.WriteLine("r = " + result);

            Console.WriteLine("c = " + Convert.ToString(c, 2).PadLeft(8, '0'));
            result = c >> 1;
            Console.WriteLine("r = " + Convert.ToString(result, 2).PadLeft(8, '0'));
            result = c >> 2;
            Console.WriteLine("r = " + Convert.ToString(result, 2).PadLeft(8, '0'));
            Console.WriteLine("r = " + result);



            Console.ReadLine();
        }

    }
}
