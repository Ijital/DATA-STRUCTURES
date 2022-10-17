using System.Collections.Generic;
using System.Diagnostics;

namespace DATA_STRUCTURES.STACK
{
    /// <summary>
    /// Stack is a data structure that is described as Last-in-first-out LIFO
    /// </summary>
    public class MyStack
    {
        public MyStack()
        {
            Creat_Stack();

            Debugger.Break();
        }

        void Creat_Stack()
        {
            Stack<int> theStack = new Stack<int>();
            theStack.Push(0);
            theStack.Push(1);
            theStack.Push(2);

            Debugger.Break();
        }
    }
}
