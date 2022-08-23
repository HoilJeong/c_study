using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataStructure_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== 제네릭 타입이 아닌 Stack =====");

            Stack stack1 = new Stack();
            stack1.Push("문자열");
            stack1.Push(1);
            stack1.Push(true);

            while (stack1.Count > 0)
            {
                Console.WriteLine(stack1.Pop());
            }

            Console.WriteLine("===== 제네릭 타입 Stack =====");

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Pop();
            stack.Push(3);
            stack.Push(4);
            stack.Peek();
            stack.Push(5);

            Console.WriteLine("스택의 갯수: " + stack.Count);

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            Console.WriteLine("===== Array Stack 구현 =====");
            ArrayStack arrayStack = new ArrayStack(5);

            arrayStack.Push(1);
            arrayStack.Push(2);
            arrayStack.Push(3);
            arrayStack.Push(4);
            arrayStack.Push(5);

            while (arrayStack.Count > 0)
            {
                Console.WriteLine(arrayStack.Pop());
            }
        }
    }
}
