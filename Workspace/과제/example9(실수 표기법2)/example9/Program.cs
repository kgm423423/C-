using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 22.0f / 7;
            double b = 22.0 / 7;
            decimal c = 22.0m / 7;

            Console.WriteLine("float 22/7 : " + a);
            Console.WriteLine("double 22/7 : " + b);
            Console.WriteLine("decimal 22/7 : " + c);

            float d = 3.14159f;
            double e = 3.1415926525d;
            decimal f = 3.141592653598793m;

            Console.ReadLine();
        }
    }
}
