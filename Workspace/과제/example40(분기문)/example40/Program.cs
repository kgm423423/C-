using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write(" 숫자를 입력 하시오. >> ");
            string input = Console.ReadLine();
            try { a = int.Parse(input); }
            catch { a = 0; };

            if (a % 2 == 0)
                Console.WriteLine(input + "은 짝수입니다.");
            else
                Console.WriteLine(input + "은 홀수입니다.");


            Console.ReadLine();
        }
    }
}
