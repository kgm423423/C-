using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            a += 10;
            Console.WriteLine("a += 10 -> {0}", a);
            a -= 5;
            Console.WriteLine("a -= 5 -> {0}", a);
            a *= 3;
            Console.WriteLine("a *= 3 -> {0}", a);
            a /= 3;
            Console.WriteLine("a /= 3 -> {0}", a);
            a %= 6;
            Console.WriteLine("a % 6 -> {0}", a);


            Console.ReadLine();
        }
    }
}
