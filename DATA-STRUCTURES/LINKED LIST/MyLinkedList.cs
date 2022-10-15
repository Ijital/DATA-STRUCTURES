﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DATA_STRUCTURES.LINKED_LIST
{
    public class MyLinkedList
    {
        LinkedList<string> myLinked = new LinkedList<string>();
        public MyLinkedList()
        {
            StartLinked();

            Debugger.Break();
        }

        void StartLinked()
        {
            // Get the total number of Nodes in the collection
            int linkedElementsCount = myLinked.Count();

            // Add the first Node
            myLinked.AddFirst("Shana");

            // Insert a node just before the node holding the value "Shana"
            myLinked.AddBefore(myLinked.Find("Shana"), "Hannah");

            // Push the first node to second and insert this new one
            myLinked.AddFirst("Melvin");

            // Add an new node at the end of the 
            myLinked.AddLast("Melvin");


            // Get the first Node containing the given value "Melvin"
            LinkedListNode<string> node = myLinked.Find("Melvin");

            // Get the first Node
            LinkedListNode<string> node1 = myLinked.First;

            // Get the Value held by the Node a given index 
            var node2 = myLinked.Find(myLinked.ElementAt(2));


            // Get a node that is previouyr to another node
            var deme = node2.Previous;

            // Iterate the Values held by LinkedList 
            foreach (string item in myLinked)
            {
                Console.WriteLine(item);
            }
        }
    }
}
