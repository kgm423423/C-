using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example72
{
    class Student
    {
        public string name;
        public int DOB;

        public Student(string name, int DOB)
        {
            this.name = name;
            this.DOB = DOB;
        }

        public int getAge()
            { return DateTime.Today.Year - DOB; }
    }
    internal class Program
    {
      
        static void Main(string[] args)
        {
            int i = 0;


            Student[] gameClass = new Student[5];
            gameClass[0] = new Student("a", 2001);
            gameClass[1] = new Student("b", 2002);
            gameClass[2] = new Student("c", 2003);
            gameClass[3] = new Student("d", 2004);
            gameClass[4] = new Student("e", 2005);

            foreach (Student st in gameClass)
            {
                Console.WriteLine("[{0}] : ({1},{2})", ++i, st.name, st.getAge());
            }
          

            Console.ReadLine();
        }
    }
}
