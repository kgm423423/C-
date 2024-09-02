using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };
            int num = Array.IndexOf(scores,90);
            Console.WriteLine("점수 90 == " + num);

            Console.Write("정렬전\n 점수 : ");
            foreach (int i in scores) Console.Write(i + " ");

            Array.Sort(scores); 
            Console.Write("\n정렬후\n 점수 : ");
            foreach (int i in scores) Console.Write(i + " ");



            Console.ReadLine();
        }
    }
}
