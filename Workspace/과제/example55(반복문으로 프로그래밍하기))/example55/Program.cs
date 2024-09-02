/*    
 이름 : 김석현  번호 : 08
 과정: 게임 콘텐츠 제작  제작일: 2024-07-03
                                             */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example55
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i, j;
            int num;

            Console.Write("층수를 입력 하세요 ...");
            num = int.Parse(Console.ReadLine());

            for (i = 0; i < num; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();


            }


            Console.WriteLine("반복 하시겠습니까? (y/n)");

            Console.ReadLine();
        }
    }
}