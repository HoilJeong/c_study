using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: _25_extension
 * DESC: 클래스 확장 함수
 */

namespace _25_extension
{
    class AA
    {
        public void PrintAA(string str)
        {
            Console.WriteLine("PrintAA" + str);
        }
    }

    static class Util
    {
        public static void Print(this AA aa, string str)
        {
            aa.PrintAA(str);
        }

        public static void Sum(this int a)
        {
            Console.WriteLine(a + " + " + a + " = " + (a + a));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();

            Util.Print(aa, "Hello");
            aa.Print("Hello"); // 이게 가능

            Util.Sum(10);
            10.Sum(); // 이게 가능
        }
    }
}
