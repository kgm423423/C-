using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example65
{
    internal class Program
    {
        static void Main(string[] args)
        {
            add(3, 4);
            add(3.14f, 2.0f);


            Console.ReadLine();
        }

        static int add(int a, int b)
        {
            Console.WriteLine("정수 더하기");
            return a + b;
        }
        static float add(float a, float b)
        {
            Console.WriteLine("실수 더하기");
            return a + b;
        }
    }
}
