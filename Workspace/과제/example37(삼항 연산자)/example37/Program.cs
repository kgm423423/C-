using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int posX;
            string result;
            int a = 30;
            Console.WriteLine(a > 50 ? "50보다 크다" : "50보다 작다");
            Console.WriteLine(a > 20 ? "20보다 크다" : "20보다 작다");

            Console.WriteLine("a = {0}, posX = {1}", a, a < 100 ? a : 100);
            a = 200;
            Console.WriteLine("a = {0}, posX = {1}", a, a < 100 ? a : 100);



            Console.ReadLine();
        }
    }
}
