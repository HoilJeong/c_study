using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: _28_property01
 * DESC: get, set 키워드 구현
 */

namespace _28_property01
{
    class AA
    {
        private int num;

        public int NUM
        {
            get { return num; }
            set { num = value; } // set부분을 구현하지 않으면 readonly와 같은 읽기 전용
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            aa.NUM = 100;

            Console.WriteLine("aa.NUM: " + aa.NUM);
        }
    }
}
