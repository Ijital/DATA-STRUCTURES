using System.Collections;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Security.Principal;
using System.Linq;
using System.Text;

namespace DATA_STRUCTURES.STACK
{
    /// <summary>
    /// Stack is a data structure that is described as Last-in-first-out LIFO
    /// </summary>
    public class MyStack
    {
        public MyStack()
        {
           bool sss=  IsValid(text);

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


        //Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the
        //input string is valid. The string is valid if all open brackets are closed by the same type of closing
        //bracket in the correct order, and each closing bracket closes exactly one open bracket.
        //For example, s = "({})" and s = "(){}[]" are valid, but s = "(]" and s = "({)}" are not valid.

        // Although this question says that the string will only contain the brackets, in test they may say that
        // the sentence would contain words as well. In this case you need to simply remove the words from the sentence
        // before continuing/ 

        // Sol:
        // Steps. Start adding the characters to stack one after the other. If the first item in a closing bracket
        // then the string in invalid. 
        // Step2. As you add the characters, any time you encounter a closing bracket, check to see if the bracket added 
        // immediately before it is a closing bracket of thesame type of bracket. If yes then pop both of them off the stack
        // and continue adding the next character in the string. 

        string text = "{{{[]{}}}}";
        bool IsValid(string sentence= null)
        {
            if (sentence[0]==')' || sentence[0] == ']'|| sentence[0] == '}')
            {
                return false;
            }


            Stack<char> theStack = new Stack<char>();

            foreach (char item in sentence)
            {
                string openClose = null;

                if (theStack.Count > 0)
                {
                    openClose = $"{theStack.Peek()}{item}";
                }

                if (item == '(' || item == '[' || item == '{')
                {
                    theStack.Push(item);
                }
                else if (openClose == "()" || openClose == "{}" || openClose == "[]")
                {
                    theStack.Pop();
                }
                else
                {
                    return false;
                }

            }
            return true;
        }

        // You are given a string s. Continuously remove duplicates (two of the same character beside each other)
        // until you can't anymore. Return the final string after this.For example, given s = "abbaca", you can first
        // remove the "bb" to get "aaca". Next, you can remove the "aa" to get "ca". This is the final answer.
        string Get_Remaining_String(string text)
        {
            Stack<char> theStack = new Stack<char>(text[0]);

            for (int i = 1; i < text.Length; i++)
            {
                if (theStack.Peek() == text[i])
                {
                    theStack.Pop();
                }
                else
                {
                    theStack.Push(text[i]);
                }
            }

            StringBuilder sb = new StringBuilder();

            while (theStack.Count>0)
            {
                sb.Insert(0, theStack.Peek());
            }

            return sb.ToString();
        }
    }
}
