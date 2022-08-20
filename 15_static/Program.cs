using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: _15_static
 * DESC: static 키워드: 정적 변수, 정적 함수
 */

namespace _15_static
{
    class AA
    {
        public static int a;
        public static int b;
        public int c;

        // 정적 함수는 반드시 정적 변수만 참조 가능
        public static void Print()
        {
            Console.WriteLine($"a: " + a);
            Console.WriteLine($"b: " + b);
            //Console.WriteLine($"c: " + c);
        }
    }

    class BB
    {
        public int a;
        public int b;

        public void Print()
        {
            Console.WriteLine($"a: " + a);
            Console.WriteLine($"b: " + b);         
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AA.a = 10;  // 객체 생성 없이 바로 접근
            AA.b = 100; // 객체 생성 없이 바로 접근

            AA.Print(); // 객체 생성 없이 바로 접근

            //BB.a = 100; // 오류
            //BB.b = 200; // 오류
            //BB.Print(); // 오류

            BB bb = new BB();
            bb.a = 100;
            bb.b = 200;

            bb.Print();
        }
    }
}
