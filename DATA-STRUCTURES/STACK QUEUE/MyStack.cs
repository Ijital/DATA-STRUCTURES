using System.Collections;
using System;
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
            Stack<int> myStack = new Stack<int>();

            // Add a new item to the end of the stack
            myStack.Push(6);
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            //Get the last item added to the stack and also remove it from the stack
            var item2 = myStack.Pop();

            // Get the last item in stack without removing it from the stack
            var item = myStack.Peek();


            // Check if the stack contains a given element
            bool has4 = myStack.Contains(4);

            // Returns the number of items in the stack
            var stackCount = myStack.Count;

            // iterating a Stack and removing the last item
            while (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Pop());
            }

            // This of Line in a Bank ATM when you think of Queue
            // The First come first Serve

            Queue<int> myQueue = new Queue<int>();

            // Add a new item to the end of the Queue
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);

            //Get the first item added to the Queue and also remove it from the Queue
            var queuItem = myQueue.Dequeue();

            // Get the first item in Ques without removing it from the stack
            var queItem = myQueue.Peek();

            // iterating a Queue and removing the first item
            while (myQueue.Count > 0)
            {
                Console.WriteLine(myQueue.Dequeue());
            }

            Console.Read();
        }
    }
}
