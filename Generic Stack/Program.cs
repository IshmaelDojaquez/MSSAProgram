using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> tenInts = new Stack<int>(10);
            bool empty = tenInts.IsEmpty();
            Console.WriteLine(empty);

            tenInts.Push(123);
            empty = tenInts.IsEmpty();
            Console.WriteLine(empty);


            tenInts.Push(456);
            tenInts.Push(-1);
            int v1 = tenInts.Pop();
            int v2 = tenInts.Pop();
            tenInts.Push(789);
            tenInts.Push(35);
            tenInts.Push(-41); 
            tenInts.Push(68);
            tenInts.Push(-8);
            tenInts.Push(999);

            bool full = tenInts.IsFull();
            Console.WriteLine(full);

            tenInts.Push(74);
            tenInts.Push(-97);
            tenInts.Push(-4);

            full = tenInts.IsFull();

            Console.WriteLine(full);

            Stack<char> Tenchars = new Stack<char>(15);
            Stack<string> tenStrings = new Stack<string>(7);
            Stack<double> tenDoubles = new Stack<double>(10);





        }

        // Questions(Debugging)

        // Does your program have any bugs?
        // Yes. If the topofstack is larger then the size of the array or smaller then 0

        // Should you test your program for bugs?
        // Always.

        // How should you test your program?
        // Testing each little portion of code right after you write it.

        // What are some of the conditions that will make your IntStack class break?
        //topofstack being larger the the size of the array or smaller the 0.

        // Can you fix these bugs?
        //Yes.

        // What is the quickest and easiest way to write the entire StringStack class?
        // Copy and Paste.  

        //Are there any gotcha's with this "quickest and easiest" way to write the entire StringStack?
        //Yes the variable types have to be changed throughout the class.

    }
}
