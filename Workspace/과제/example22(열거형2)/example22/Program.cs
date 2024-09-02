using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example22
{
    enum Range { Min = 1, Max = 999 }
    internal class Program
    {
        static void Main(string[] args)
        {
            Range poxX = Range.Max;

            int posMax = (int)Range.Max;
            int posMin = (int)Range.Min;

            Console.WriteLine("posX = " + poxX);
            Console.WriteLine("posMax = " + posMax);
            Console.WriteLine("posMin = " + posMin);

            Console.ReadLine();
        }
    }
}
