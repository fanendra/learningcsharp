using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDataStructures
{
    public class mystack
    {
        private int[] stack;
        private int top;
        private int max;

        public mystack(int size)
        {
            stack = new int[size];
            top = -1;
            max = size;
        }

        private bool isStackEmpty()
        {
            if (top == -1)
                return true;

            return false;
        }

        private bool isStackFull()
        {
            if (top == max - 1)
                return true;

            return false;
        }

        public void Push(int ele)
        {
            if (!isStackFull())
            {
                stack[++top] = ele;
            }
            else
            {
                Console.WriteLine("Stack is Full");
            }
        }

        public int Pop()
        {
            if (!isStackEmpty())
            {
                top = top - 1;
                return stack[top + 1];
            }
            else
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
        }

        public void PrintStack()
        {
            while (!isStackEmpty())
            {
                Console.WriteLine(Pop());
            }
        }

    }
}
