using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0b00000011, b = 0b00000110, c = 12, result;
            int mask = 0b11110000;

            result = a & b;
            Console.WriteLine(result);

            result = a | b;
            Console.WriteLine(result);

            b = 0b10110110;
            result = mask & b;
            Console.WriteLine(result);

            result = mask | a;
            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
