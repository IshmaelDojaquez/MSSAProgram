using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class CharStack
    {
        //Fields & Properties

        private int size;  //initially 0 by default
        private char[] stack;
        private int topOfStack;


        //Constructors

        public CharStack(int size)
        {
            this.size = size;
            stack = new char[size];
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
        public char Pop()
        {
            if (topOfStack > 0)
            {
                topOfStack--;
                return stack[topOfStack];
            }
            else
            {
                return ' ';
            }

        }

        public void Push(char charToPush)
        {
            if (topOfStack < size)
            {
                stack[topOfStack] = charToPush;
                topOfStack++;
            }
        }
    }
}
