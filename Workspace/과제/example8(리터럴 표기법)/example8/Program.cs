using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 07;
            byte b = 0000111;
            byte c = 0b0000111;
            byte d = 0b11110000;
            byte e = 0xF0;



            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
            Console.WriteLine("e = " + e);

            Console.ReadLine();
        }
    }
}
