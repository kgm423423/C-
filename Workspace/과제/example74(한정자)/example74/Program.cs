using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example74
{
    class Person
    {
        public string name;
        protected int date;
        private int number;
    }
    class Student : Person
    {
        public String school;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            Person p1 = new Person();
            st1.name = "aaaaa";
            st1.school = "bbbbb";

            Console.WriteLine("{0}은 {1}학생 입니다.", st1.name, st1.school);


            Console.ReadLine();
        }
    }
}
