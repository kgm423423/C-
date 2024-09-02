using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            string input;
            Console.Clear();
            Console.Write("점수를 입력하시오 : ");
            input = Console.ReadLine();
            try { a = int.Parse(input); } 
            catch { a = 0; };    

            if (a > 90)
                Console.WriteLine("당신의 점수는 A학점입니다.");
            else if (a > 80)
                Console.WriteLine("당신의 점수는 B학점입니다.");
            else if (a > 70)
                Console.WriteLine("당신의 점수는 C학점입니다.");
            else if (a > 60)
                Console.WriteLine("당신의 점수는 D학점입니다.");
            else if (a > 50)
                Console.WriteLine("당신의 점수는 E학점입니다.");
            else
                Console.WriteLine("당신의 점수는 F학점입니다.");


            Console.ReadLine();
        }
    }
}
