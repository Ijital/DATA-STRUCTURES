using DATA_STRUCTURES.ARRAYS;
using DATA_STRUCTURES.LINKED_LIST;
using System;
using System.Diagnostics;

namespace DATA_STRUCTURES
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MelLinked A = new MelLinked();

            A.AddLast(2);
            A.AddLast(5);

            A.AddLast(4);
            A.AddLast(3);

            A.AddLast(11);

            A.AddLast(17);

            A.AddLast(7);
            A.AddLast(13);

            A.AddLast(15);
            A.AddLast(1);

            //A.AddLast(19);



          var gg = A.Get_Middle_Node();

            //new MyLinkedList();

            //new Matrix();

            // new SubArrays();

            //new OneItem();

            //new TwoItems();

            //new SubSequence();

            Debugger.Break();
        }
    }
}
