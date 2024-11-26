using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example73
{
    public class Person
    {
        public string name;
        public int age;
    }
    public class Student : Person
    {
        public int number;
        public int grade;
    } 
    public class Teacher : Person
    {
        public string subject;
        public int year;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Student st1 = new Student();
            Teacher t1 = new Teacher();
            Person t2 = new Teacher();

            p1.age = 99;
            p1.name = "aaaaa";

            st1.name = "bbbbb";
            st1.age = 9;
            st1.number = 99;
            st1.grade = 999;

            t1.name = "ccccc";
            t1.age = 99;
            t1.subject = "ddddd";
            t1.year = 2000;
            Console.WriteLine("{0}은 {1}세 입니다.", p1.name, p1.age);
            Console.WriteLine("{0}은 {1}세 입니다.", st1.name, st1.age);
            Console.WriteLine("학번:{0}, 학점:{1}", st1.number, st1.grade);
            Console.WriteLine("{0}은 {1}세 입니다.", t1.name, t1.age);
            Console.WriteLine("과목:{0}, 입사년도:{0}", t1.subject, t1.year);


            Console.ReadLine();
        }
    }
}
