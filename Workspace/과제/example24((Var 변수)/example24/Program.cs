using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 20;
            var b = 3.141592f;
            var c = "Hello world";
            var d = '김';


            Console.WriteLine("Type : {0}, Value : {1}", a.GetType(), a);
            Console.WriteLine("Type : {0}, Value : {1}", b.GetType(), b);
            Console.WriteLine("Type : {0}, Value : {1}", c.GetType(), c);
            Console.WriteLine("Type : {0}, Value : {1}", d.GetType(), c);



            Console.ReadLine();
        }
    }
}
