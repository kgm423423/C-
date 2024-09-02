using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, sum = 0, num = 0;

            Console.Clear();
            Console.Write(" 숫자를 입력하세요 : ");
            num = int.Parse(Console.ReadLine());

            while (a < num)
                sum += ++a;

            Console.WriteLine("{0} : 합계는 {1} 입니다.", a, sum);



            Console.ReadLine();
        }
    }
}
