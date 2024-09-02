using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 30; int b = 20;
            a++;

            Console.WriteLine(a++);
            Console.WriteLine(a);
            Console.WriteLine(++a);
            Console.WriteLine(a);
            b = a++;
            Console.WriteLine("a = {0} b = {1}", a, b);
            b = ++a;
            Console.WriteLine("a = {0} b = {1}", a, b);



            Console.ReadLine();

        }
    }
}
