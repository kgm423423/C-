using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10; int speed = 20;
            a = a + 10;

            Console.WriteLine("a = {0}", a);
            a += speed;
            Console.WriteLine("a = {0}", a);
            a += speed;
            Console.WriteLine("a = {0}", a);
            a += speed;

            Console.WriteLine("a = {0}", a);




            Console.ReadLine(); 
        }
    }
}
