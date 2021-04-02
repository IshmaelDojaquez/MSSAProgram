using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack<T>
    {
        //Fields & Properties

        private int size;  //initially 0 by default
        private T[] stack;
        private int topOfStack;


        //Constructors

        public Stack(int size)
        {
            this.size = size;
            stack = new T[size];
        }

        //Methods
        public bool IsFull()
        {
            if (topOfStack >= size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsEmpty()
        {
            if (topOfStack <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public T Pop()
        {
            if (topOfStack > 0)
            {
                topOfStack--;
                return stack[topOfStack];
            }
            else
            {
                return default(T);
            }

        }

        public void Push(T valueToPush)
        {
            if (topOfStack < size)
            {
                stack[topOfStack] = valueToPush;
                topOfStack++;
            }
        }
    }
}
