using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: _14_this
 * DESC: this 키워드: 객체 자신을 참조하는 키워드
 */

namespace _14_this
{
    class Program
    {
        class AA
        {
            int a;

            public AA(int a)
            {
                this.a = a;
            }

            public void Print()
            {
                int a = 100;
                this.a = 1000;

                Console.WriteLine($"a: " + a);
                Console.WriteLine($"this.a: " + this.a);
            }
        }

        static void Main(string[] args)
        {
            AA aa = new AA(10);
            aa.Print();
        }
    }
}
