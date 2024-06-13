using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("이름 : 김석현");
            Console.WriteLine("원적교 : 경상고등학교");
            Console.WriteLine("전화번호 : 010-2036-3743");
            Console.WriteLine("혈액형 : B");

            Console.Write("좋아하는 색상 : ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("■");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("■");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("■");
            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("좋아하는 음식 : 단 음식");

            Console.WriteLine("프로그램을 종료하려면 Enter 키를 누르세요.");
            Console.ReadLine();
        }
    }
}
