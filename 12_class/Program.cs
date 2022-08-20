using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: _12_class
 * DESC: 클래스 기본
 */

namespace _12_class
{
    class AA
    {
        // 멤버 변수
        int num1;
        public int num2, num3;

        // 멤버 함수
        public void Print()
        {
            Console.WriteLine($"aa: " + num1 + " bb: " + num2 + " cc: " + num3);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            //aa.num1 = 10; // 오류
            aa.num2 = 100;
            aa.num3 = 1000;

            aa.Print();
        }
    }
}
