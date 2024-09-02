using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100, b = 200, c = 100;
            bool result;

            result = (a < b);
            Console.WriteLine("result = (a < b) : " + result);

            result = (a > b);
            Console.WriteLine("result = (a > b) : " + result);

            result = (a >= b);
            Console.WriteLine("result = (a >= b) : " + result);
            result = (a <= b);
            Console.WriteLine("result = (a <= b) : " + result);

            result = (a == b);
            Console.WriteLine("result = (a == b) : " + result);
            result = (a != b);
            Console.WriteLine("result = (a != b) : " + result);

            result = !result;
            Console.WriteLine("result = !result : " + result);
            result = !result;
            Console.WriteLine("result = !result : " + result);



            Console.ReadLine();
        }
    }
}
