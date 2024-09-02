using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace example61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack<int> s = new Stack<int>();
            Stack s = new Stack();

            s.Push(10);
            s.Push("송중기");
            s.Push(3.14159f); 
            s.Push('d');
            s.Push(0.154389d);

            while (s.Count != 0)
            {
                Console.Write("stack 크기는 ");
                Console.WriteLine(", stack 현재 데이터는 " + s.Pop());
            }


         
            Console.ReadLine();
        }
    }
}
