using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
이름 : 김석현
번호 : 2024005
과정: 게임 콘텐츠 제작
제작일: 2024-07-12
*/

namespace _3
{

    internal class Program
    {

        static void Main(string[] args)
        {
            // #1 변수 선언
            string input;
            int num;
            bool restart;


            do
            {
                // #2 값 입력받기 
                Console.Write("피라미드의 층수를 입력하시오 : ");
                input = Console.ReadLine();
                while (true)
                {
                    //예외 처리
                    try { num = int.Parse(input); }
                    catch
                    {
                        Console.Clear();
                        Console.Write("다시 입력하시오 : ");
                        input = Console.ReadLine();
                        continue;
                    }
                    break;
                }


                // #3 피라미드 출력
                for (int i = 1; i <= num; i++)
                {
                    for (int j = (num - i); j > 0; j--)
                        Console.Write(' ');
                    for (int j = (i * 2); j > 1; j--)
                        Console.Write('*');
                    Console.Write("\n");
                }
                Console.Write("\n");


                // #4 반복 확인
                while (true)
                {
                    Console.Write("반복하사겠습니까? (y / n) : ");
                    input = Console.ReadLine();

                    if (input == "y" || input == "Y")
                        restart = true;
                    else if (input == "n" || input == "N")
                        restart = false;
                    else
                    {
                        Console.Clear();
                        continue;
                    }


                    break;
                }
                Console.Clear();

            }while(restart);
        }
    }
}
