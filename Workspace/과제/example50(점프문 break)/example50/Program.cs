using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            while(true)
            {
                Console.WriteLine("looping..");
                Console.WriteLine("프로그램을 끝내려면 y를 입력하시오");
                input = Console.ReadLine();
                if (input == "y") break;
            }



            Console.ReadLine();
        }
    }
}
