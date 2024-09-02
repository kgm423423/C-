using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example23
{
    internal class Program
    {
        enum DialonResult { Yes = 10, NO, CANCEL, CONFIRM = 50, OK}

        static void Main(string[] args)
        {
            Console.WriteLine("DialogResult.Yes = " + (int)DialonResult.Yes);
            Console.WriteLine("DialogResult.NO = " + (int)DialonResult.NO);
            Console.WriteLine("DialogResult.CANCEL = " + (int)DialonResult.CANCEL);
            Console.WriteLine("DialogResult.CONFIRM = " + (int)DialonResult.CONFIRM);
            Console.WriteLine("DialogResult.OK = " + (int)DialonResult.OK);
            


            Console.ReadLine();
        }
    }
}
