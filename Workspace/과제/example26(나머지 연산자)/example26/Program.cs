using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a; int mod;
            a = 3 / 2; mod = 3 % 2;
            Console.WriteLine(" 3 / 2 = " + a);
            Console.WriteLine(" 3 % 2 = " + mod);

            for(a = 27870; a <= 27879; a++) 
                Console.WriteLine("{0} %% 6 = {1}", a, a % 6);


            Console.ReadLine();
        }
    }
}
