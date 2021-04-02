using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class IntStack
    {
        //Fields & Properties

        private int size;  //initially 0 by default
        private int[] stack;
        private int topOfStack;


        //Constructors

        public IntStack(int size)
        {
            this.size = size;
            stack = new int[size];
        }

        //Methods
        public bool IsFull()
        {
            if(topOfStack >= size)
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
        public int Pop()
        {
            if (topOfStack > 0)
            {
                topOfStack--;
                return stack[topOfStack];
            }
            else
            {
                return 0;
            }

        }

        public void Push(int valueToPush)
        {
            if(topOfStack < size)
            {
                stack[topOfStack] = valueToPush;
                topOfStack++;
            }
        }
    }
}
