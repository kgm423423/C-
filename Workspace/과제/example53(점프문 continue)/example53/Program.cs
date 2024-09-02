using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 30; i++)
            {
                if (i%3 == 0)
                {
                    Console.WriteLine(">>> 박수 <<< ");
                    continue;
                }
                sum += i;
                Console.WriteLine("{0,3}:{1,4}", i, sum);
            }



            Console.ReadLine(); 
        }
    }
}
