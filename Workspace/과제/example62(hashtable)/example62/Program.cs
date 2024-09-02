using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();

            table.Add("name", "홍길동");
            table.Add("age", 20);
            table.Add("addr", "인천 남동구");
            table.Add("type", 'A');
            table.Add("email", "423423@!!");

            Console.WriteLine("hashtable 크기는" + table.Count);

            Console.WriteLine(table["name"]);
            Console.WriteLine(table["age"]);
            Console.WriteLine(table["addr"]);
            Console.WriteLine(table["type"]);
            Console.WriteLine(table["email"]);



            Console.ReadLine();
        }
    }
}
