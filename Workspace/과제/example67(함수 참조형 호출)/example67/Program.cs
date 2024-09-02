using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example67
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 30, b = 40;
            Console.WriteLine("x::{0}, y{1}", a, b);
            swap(ref a, ref b);
            Console.WriteLine("x::{0}, y{1}", a, b);


            Console.ReadLine();
        }

        static void swap(ref int x, ref int y)
        {
            (x, y) = (y, x);
        }
    }
}
