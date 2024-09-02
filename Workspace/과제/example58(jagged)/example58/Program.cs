using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[5] { 1, 2, 3, 4, 5 };
            arr[1] = new int[] { 10, 20, 30 };
            arr[2] = new int[] { 100, 200 };

            foreach (int[] i in arr)
            {
                Console.Write($"Length : {i.Length}, ");
                foreach (int j in i)
                {
                    Console.Write($"{j} ");
                }
                Console.Write("\n");
            }


            Console.ReadLine();
        }
    }
}
