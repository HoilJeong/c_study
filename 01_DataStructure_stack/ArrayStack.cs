using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataStructure_stack
{
    class ArrayStack
    {
        private int[] space;
        private int top;
        public int Count
        {
            get
            {
                return top + 1;
            }
        }

        public ArrayStack(int size)
        {
            space = new int[size];
            top = -1;
        }

        public void Push(int value)
        {
            top++;
            space[top] = value;
        }

        public int Pop()
        {
            int value = space[top];
            space[top] = 0;
            top--;

            return value;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == space.Length - 1;
        }
    }
}
