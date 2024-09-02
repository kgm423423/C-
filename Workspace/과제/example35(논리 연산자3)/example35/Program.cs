using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20, c = 30;
            bool result;

            result = (a < b) && (a > c);
            Console.WriteLine("result = (a < b) && (a > c) = " + result);
            result = (a < b) && !(a > c);
            Console.WriteLine("result = (a > b) && !(a > c) = " + result);



            Console.ReadLine();
        }
    }
}
