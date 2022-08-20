using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: _19_class_base
 * DESC: base 키워드
 */

namespace _19_class_base
{
    class Super
    {
        int num;
        protected string name;

        public Super(int num)
        {
            this.num = num;
        }

        public void PrintSuper()
        {
            Console.WriteLine($"Super num: " + num);
        }
    }

    class Sub : Super
    {
        string name;
        public Sub(int num, string name) : base(num)
        {
            this.name = name;
        }

        public void PrintSub()
        {
            base.name = "Super";
            base.PrintSuper();

            Console.WriteLine($"Super name: " + base.name);
            Console.WriteLine($"Sub name: " + this.name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sub sub = new Sub(26, "Jack");
            sub.PrintSub();
        }
    }
}
