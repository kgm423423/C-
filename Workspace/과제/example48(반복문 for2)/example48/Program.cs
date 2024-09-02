using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dan = 7, result = 0;

            Console.Write("원하는 단 번호를 입력하시오 : ");
            dan = int.Parse(Console.ReadLine());

            for (int i = 1; i <= dan; i++)
            {
                Console.WriteLine("===={0}단 입니다====", i);
                for(int j=1; j <= 9; j++)
                {
                    result = i * j;
                    Console.WriteLine("\t{0}x{1}={2}", i, j, result);
                }
                Console.Write("\n\n");
            }


            Console.ReadLine();
        }
    }
}
