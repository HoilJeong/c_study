using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: _20_as
 * DESC: as, is 키워드 기본
 */

namespace _20_as
{
    class Base
    {
        int num;

        public void Print()
        {
            Console.WriteLine($"num: " + num);
        }
    }

    class AA : Base
    {
        int a;

        public void PrintA()
        {
            Console.WriteLine($"a: " + a);
        }
    }

    class BB : Base
    {
        int b;

        public void PrintB()
        {
            Console.WriteLine($"b: " + b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Base _base = new Base();
            _base.Print();

            Base aa = new AA();
            aa.Print();

            if (aa is BB)
            {
                Console.WriteLine("aa는 BB의 객체입니다");
            }
            else if (aa is AA)
            {
                Console.WriteLine("aa는 AA의 객체입니다");
            }

            Base bb = new BB();

            BB copyBB = bb as BB;
            if (null != copyBB)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("copyBB는 BB객체를 형식 변환");
                copyBB.PrintB();
            }

            Base copyAA = bb as AA;
            if (null == copyAA)
            {
                Console.WriteLine("------------------------------"); ;
                Console.WriteLine("bb는 AA객체가 아니므로 null");

                copyAA = new AA();
                copyAA.Print();
                //copyAA.PrintA(); // 오류(다형성으로 가능)

                AA asAA = copyAA as AA;
                asAA.PrintA();
            }
        }
    }
}
