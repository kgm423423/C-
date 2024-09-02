using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            string dataName = "";
            Console.Write("요일 넘버를 입력하세요 (1 ~ 7) : ");
            string input = Console.ReadLine();
            try { num = int.Parse(input); }
            catch { num = 0; };

            switch (num)
            {
                case 1:
                    dataName = "월요일";
                    break;
                case 2:
                    dataName = "화요일";
                    break;
                case 3:
                    dataName = "수요일";
                    break;
                case 4:
                    dataName = "목요일";
                    break;
                case 5:
                    dataName = "금요일";
                    break;
                case 6:
                    dataName = "토요일";
                    break;
                case 7:
                    dataName = "일요일";
                    break;
            }
            Console.WriteLine("오늘은 {0} 입니다.", dataName);



            Console.ReadLine();
        }
    }
}
