using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  
  이름 : 김석현
  번호 : 08
  과정: 게임 콘텐츠 제작
  제작일: 2024-06-28
*/

namespace example54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #1 변수 선언
            int n;
            string str;
            bool flag = true;

            // #2 반복
            while (flag)
            {
                // #3 값 입력받기
                input:
                Console.Clear();
                Console.Write("층수 입력 : ");
                try { n = int.Parse(Console.ReadLine()); } //예외 처리 
                catch
                {
                    Console.WriteLine("입력 오류 다시 입력하세요.");
                    Console.ReadLine();
                    goto input; //3번 주석으로 이동
                }


                // #4 출력
                for (int i = 0; i < n; i++)
                {
                    for(int j = n; j > i; j--) 
                        Console.Write(' ');
                    for(int j = 0; j <= (i*2);j++)
                        Console.Write('*');
                    Console.Write('\n');
                }
                Console.ReadLine();


                // #5 반복 여부 확인
                while (true)
                {
                    Console.Clear();
                    Console.Write("반복하시겠습니까? (Y/N) : ");
                    str = Console.ReadLine();

                    if (str == "N" || str == "n")
                        flag = false;
                    else if (str == "Y" || str == "y") { }
                    else 
                        continue;

                    break;
                }
            }
        }
    }
}
