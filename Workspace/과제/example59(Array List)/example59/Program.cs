using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3 };
            ArrayList list = new ArrayList()
            {
                1,2,3,4, "구월산", arr
            };

            Console.WriteLine("list 크기 : " + list.Count);

            foreach (var i in list) { Console.Write(i + " "); }
            Console.Write("\n");

            list.Add(333);
            foreach (var i in list) { Console.Write(i + " "); }
            Console.Write("\n");

            list.RemoveAt(3);
            foreach (var i in list) { Console.Write(i + " "); }
            Console.Write("\n");

            list.Insert(2, "세번쨰");
            foreach (var i in list) { Console.Write(i + " "); }
            Console.Write("\n");

            Console.WriteLine("list 크기 : " + list.Count);


            Console.ReadLine();
        }
    }
}
