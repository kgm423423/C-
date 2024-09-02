using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, num = 0, inc = 0;

            Console.Clear();
            Console.Write("숫자를 입력하시오 : ");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                sum += i;
                Console.WriteLine("{0} : {1}", i, sum);
            }
            Console.WriteLine("전체 합은 {0}입니다..", sum);


            Console.ReadLine();
        }
    }
}
