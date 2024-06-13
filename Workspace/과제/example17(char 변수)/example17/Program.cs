using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char key = 's';
            int keyNum = 65;

            Console.WriteLine(key);

            key = (char)keyNum;
            Console.WriteLine(key); 
            key = (char)(keyNum+1);
            Console.WriteLine(key);

            key = (char)(keyNum+32);
            Console.WriteLine(key);

            Console.ReadLine();
        }
    }
}
