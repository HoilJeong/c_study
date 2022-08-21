using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: _24_partial
 * DESC: partial 기본
 */

namespace _24_partial
{
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            aa.SetNum(10);
            aa.ADD();

            aa.SetNum(100);
            aa.MUL();
        }
    }
}
