using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;  //선언
            a = 10; //초기화

            int b = 20;

            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);
            Console.WriteLine("-----------");
            a = b;
            Console.WriteLine("a = b");
            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);
            //Console.WriteLine("-----------");
            //Console.WriteLine("a + b = " + (a + b));

            Console.Read();
        }
    }
}
