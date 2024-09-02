using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace example64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20, b = 30;
            Console.WriteLine("add(a,b) = {0}", add(a, b));
            Console.WriteLine("minus(a,b) = {0}", minus(b, a));


            Console.ReadLine();
        }

        static int add(int a, int b)
        {
            return a + b;
        }
        static int minus(int a, int b)
        {
            return a - b;
        }
    }
}
