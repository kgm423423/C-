using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue("송중기");
            q.Enqueue(3.14f);
            q.Enqueue(0.15d);
            q.Enqueue(500);
            q.Enqueue("바나나");

            while (q.Count != 0)
            {
                Console.Write("q의 크기는 : " +q.Count);
                Console.WriteLine(", 현재 q의 값" + q.Dequeue());
            }


            Console.ReadLine();
        }
    }
}
