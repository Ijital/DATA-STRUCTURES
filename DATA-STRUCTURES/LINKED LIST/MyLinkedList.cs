using System;
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


            // Add an new node at the end of the 
            myLinked.AddLast("Kelvin");

            // Add an new node at the end of the 
            myLinked.AddLast("Terson");


            var tese = Get_Reverse_LinkedList(myLinked);


            // Iterate the Values held by LinkedList 
            foreach (string item in myLinked)
            {
                Console.WriteLine(item);
            }


            // Get the first Node containing the given value "Melvin"
            LinkedListNode<string> node = myLinked.Find("Melvin");


            // Get the first Node
            LinkedListNode<string> node1 = myLinked.First;

            // Gets the last Element in the list
            LinkedListNode<string> node4 = myLinked.Last;


            // Get the Value held by the Node a given index 
            LinkedListNode<string> node2 = myLinked.Find(myLinked.ElementAt(2));


            // Get a node that is previouyr to another node
            LinkedListNode<string> deme = node2.Previous;

        }

        // There is sometimes a question to reveres the items in a linked list
        // In other language, the implementation of a linked list node allows
        // manipulation of node.next property but in C# this property is read only
        // Consequently we can only achive thesame task by reversing the values
        // held by the nodes and not the nodes themselves. I.e we use thesame 
        // Algortihgm for getting the palindrom of a string
        LinkedList<string> Get_Reverse_LinkedList (LinkedList<string> list)
        {
            LinkedList<string> tempList = new LinkedList<string>();

            foreach (var item in list)
            {
                tempList.AddFirst(item);
            }
            return tempList;
        }
    }
}
