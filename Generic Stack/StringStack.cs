using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class StringStack
    {
        //Fields & Properties

        private int size;  //initially 0 by default
        private string[] stack;
        private int topOfStack;


        //Constructors

        public StringStack(int size)
        {
            this.size = size;
            stack = new string[size];
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
        public string Pop()
        {
            if (topOfStack > 0)
            {
                topOfStack--;
                return stack[topOfStack];
            }
            else
            {
                return " ";
            }

        }

        public void Push(string stringToPush)
        {
            if (topOfStack < size)
            {
                stack[topOfStack] = stringToPush;
                topOfStack++;
            }
        }
    }
}
