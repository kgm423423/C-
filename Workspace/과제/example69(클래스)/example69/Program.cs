using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example69
{
    class Cat
    {
        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine("야옹!! 나는 {0} 고양이 이름은 {1}이다", Color, Name);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            cat1.Name = "나비";
            cat1.Color = "하얀색";
            cat1.Meow();

            Cat cat2 = new Cat();
            cat2.Name = "네로";
            cat2.Color = "검은색";
            cat2.Meow();


            Console.ReadLine();
        }
    }
}
