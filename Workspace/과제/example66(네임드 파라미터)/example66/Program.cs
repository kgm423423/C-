using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example66
{
    internal class Program
    {
        static void Main(string[] args)
        {
            printInfo(num: 12345, name: "송중기");
            printInfo(name: "송중기");
            printInfo();


            Console.ReadLine();
        }
        static void printInfo(string name, int num)
        {
            Console.WriteLine("{0}의 학번은 {1}.\n", name, num);
        }
        static void printInfo(string name)
        {
            Console.WriteLine("나의 이름은 {0}입니다.\n", name);
        }
        static void printInfo()
        {
            Console.WriteLine("나는 게임학과 학생입니다.\n");
        }
    }
}
