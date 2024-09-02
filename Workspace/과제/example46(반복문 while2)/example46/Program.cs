using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0;

            do
            {
                Console.WriteLine(n1 + " : do while");
                n1++;
            } while (n1 < 10);
            Console.Write("\n\n\n");

            while (n2 < 10)
            {
                Console.WriteLine(n2 + " : while");
                n2++;
            } 

            Console.ReadLine();
        }
    }
}
