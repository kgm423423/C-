using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = new String[5] { "mon", "tue", "wed", "thurs", "fri" };
            string[] arr2 = new String[] { "mon", "tue", "wed", "thurs" };
            string [] arr3 = new String[] { "mon", "tue", "wed" };
            string day = arr1[1];

            arr2[0] = "월요일";

            int i = 0;
            foreach (string s in arr1)
            {
                Console.WriteLine("{0} : {1}", i, s);
                i++;
            }



            Console.ReadLine();
        }
    }
}
