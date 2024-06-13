using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "null";

            Console.Title = " 출력문 연습 ";
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Yellow;  // 배경

            Console.ForegroundColor = ConsoleColor.Red;   // 문자

            //Console.Write("이름 입력 : ");
            //Console.Beep();

            //name = Console.ReadLine();
            //Console.Beep();


            //Console.Write("name : ");
            //Console.Write(name);



            Console.WriteLine("이름 : 김석현");
            Console.Beep();
            Console.WriteLine("원적교 : 경상고등학교");
            Console.Beep();
            Console.WriteLine("전화번호 : 010-2036-3743");
            Console.Beep();
            Console.WriteLine("혈액형 : B");
            Console.Beep();
            Console.Write("좋아하는 색상 : ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("■");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("■");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("■");
            Console.Write("\n");
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("좋아하는 음식 : 단 음식");
            Console.Beep();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;



            Console.ReadKey(); // 키 입력
        }
    }
}
