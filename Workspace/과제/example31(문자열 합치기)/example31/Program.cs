using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "100";
            string b = "200";
            int sum = int.Parse(a) + int.Parse(b);
            Console.WriteLine("a + b = {0}", a+b);
            Console.WriteLine("sum = int.Parse(a) + int.Parse(b) = " + sum);
            sum = Convert.ToInt16(a) + 10;
            Console.WriteLine("sum = int.Parse(a) + int.Parse(b) = "+ sum);



            Console.ReadLine();
        }
    }
}
