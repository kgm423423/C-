using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example68
{
    internal class Program
    {
        static void divide (int a,int b, out int q, out int r)
        {
            q = a / b;
            r = a % b;
        }
        static void Main(string[] args)
        {
            int a = 20, b = 3;
            int q, r;
            divide(a, b, out q, out r);
            Console.WriteLine("20/3의 몫은 {0} ", q);
            Console.WriteLine("20/3의 나머지는 {0} ", r);


            Console.ReadLine();
        }

        
    }
}
