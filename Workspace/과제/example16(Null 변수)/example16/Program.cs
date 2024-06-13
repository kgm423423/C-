using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? a;

            a = null;

            Console.WriteLine(a.HasValue);

            a = 3;      //0으로 하는게 더 좋을듯

            Console.WriteLine(a);
            Console.WriteLine(a.HasValue);

            Console.ReadLine(); 
        }
    }
}
