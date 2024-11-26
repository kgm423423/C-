using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example70
{
    class Student
    {
        public string name;
        public int number;
        public int grade;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            Student st2 = new Student();
            st1.grade = 90;

            st2.name = "전지현";
            st2.number = 5678;
            st2.grade = 90;

            Console.WriteLine("이름 : " + st1.name);
            Console.WriteLine("학번 : " + st1.number);
            Console.WriteLine("점수" + st1.grade);

            Console.Write("\n");

            Console.WriteLine("이름 : " + st2.name);
            Console.WriteLine("학번 : " + st2.number);
            Console.WriteLine("점수" + st2.grade);

            Console.ReadLine();
        }
    }
}
