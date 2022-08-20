﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: _16_class_parameter
 * DESC: 클래스 객체의 복사를 통한 래퍼런스 처리 및 객체 생성 후 리턴되는 값 확인
 */

namespace _16_class_parameter
{
    class AA
    {
        public int a;
        public int b;

        public AA()
        {
            a = 0;
            b = 0;
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"a: " + a);
            Console.WriteLine($"b: " + b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            aa.Print();

            CopyRefClass(aa);
            aa.Print();

            AA aaa = CopyDeepClass(aa);
            aaa.Print();

            aa.Print();
        }

        static void CopyRefClass(AA aa)
        {
            AA refAA = aa;
            refAA.a = 100;
            refAA.b = 10000;
        }

        static AA CopyDeepClass(AA aa)
        {
            AA tempAA = new AA();

            tempAA.a = aa.a;
            tempAA.b = aa.b;

            tempAA.a = 0;

            return tempAA;
        }
    }
}
