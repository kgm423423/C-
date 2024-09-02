using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace example21
{
    internal class Program
    {
        enum Days { Sun, Mon, Tue, Wen, Thu, Fri, Sat }
        static void Main(string[] args)
        {
            Days today = Days.Wen;
            Days tomorrow = Days.Tue;

            Console.WriteLine("오늘은 " + today + " 입니다,");
            Console.WriteLine("내일은 " + tomorrow + " 입니다.");

            Console.WriteLine("Days.Sun = " + (byte)Days.Sun);
            Console.WriteLine("Days.Mon = " + (byte)Days.Mon);
            Console.WriteLine("Days.Tue = " + (byte)Days.Tue);
            Console.WriteLine("Days.Wen = " + (byte)Days.Wen);
            Console.WriteLine("Days.Thu = " + (byte)Days.Thu);
            Console.WriteLine("Days.Fri = " + (byte)Days.Fri);
            Console.WriteLine("Days.Sat = " + (byte)Days.Sat);



            Console.ReadLine();
        }
    }
}
