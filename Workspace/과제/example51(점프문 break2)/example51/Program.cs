using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("{0}:{1}", i, sum+=i);
                if (i > 10) break;
            }



            Console.ReadLine();
        }
    }
}
