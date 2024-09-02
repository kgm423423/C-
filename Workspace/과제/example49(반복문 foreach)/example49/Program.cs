using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] list = new string[] { "A", "B", "C", "D", "E", "F" };

            foreach (string name in list)
            {
                Console.WriteLine(name);
            }



            Console.ReadLine();
        }
    }
}
