using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example71
{
    class Student
    {
        public string name;
        public int number;
        public int DOB;

        public Student() { Console.WriteLine("학생 기본 생성자"); }
        public Student(string input_name)
        {
            name = input_name;
            Console.WriteLine("제 이름은 {0}입니다." , name);
        }
        public Student(string input_name, int input_DOB)
        {
            name = input_name; DOB = input_DOB;
            int age = (DateTime.Today.Year - DOB);
            Console.WriteLine("나는 {0}살 {1}입니다.", age, name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            Student st2 = new Student("aaaaa");
            Student st3 = new Student("bbbbb", 99);


            Console.ReadLine();
        }
    }
}
