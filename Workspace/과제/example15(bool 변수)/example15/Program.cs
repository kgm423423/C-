using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace example15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;

            Console.WriteLine(a);
            Console.WriteLine(b);



            a = (300 > 200);
            b = (200 < 300);

            Console.WriteLine("300 > 200 = " + a);
            Console.WriteLine("200 < 300 = " + b);

            Console.ReadLine();
        }
    }
}
