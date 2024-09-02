using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 30; int b = 20;
            a--;

            Console.WriteLine("a = {0}", a);
            b = a--;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);

            b = --a;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);


            Console.ReadLine();        
        }
    }
}
