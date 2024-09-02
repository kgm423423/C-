using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 0b0000_0110;
            b = ~a;
            Console.WriteLine("### not 연산자 실습 ###");
            Console.WriteLine("a = 0b{0}, b = 0b{1}", Convert.ToString(a, 2), Convert.ToString(b, 2));

            Console.WriteLine();

            Console.WriteLine("### xor 연산자 실습 ###");
            b = 0b0000_1100;
            c = a ^ b;
            Console.WriteLine("a ^ b = 0b{0}", Convert.ToString(c, 2));

            b = 0b0000_0110;
            c = a ^ b;
            Console.WriteLine("a ^ b = 0b{0}", Convert.ToString(c, 2));



            Console.ReadLine();

        }
    }
}
