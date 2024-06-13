using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int a = 10;
                int b = 20;
                int c = 30;

                a = 20;

                Console.WriteLine("a = " + a);
                Console.WriteLine("b = " + b);
                Console.WriteLine("c = " + c);
            }

            Console.Write("\n");

            {
                int a = 100;
                float b = 3.141592f;

                Console.WriteLine("b = " + a);
                Console.WriteLine("c = " + b);
            }

            Console.ReadLine();
        }   
    }
}
