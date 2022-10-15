
using System.Collections.Generic;

namespace DATA_STRUCTURES.LINKED_LIST
{

    public class MelNode
    {
        int _data;
        public MelNode(int data)
        {
            this._data = data;
        }
        public MelNode Next { get; set; }
        public MelNode Previous { get; set; }
    }


    public class MelLinked
    {
        public MelNode Head { get; set; }

        public MelNode Last { get; set; }

        public void AddLast(int data)
        {
            MelNode node =  new MelNode(data);

            if (Head == null)
            {
                Head = node;
                Last = Head;
                Head.Previous = null;
            }
            else
            {
                MelNode lastNode = Last;
                lastNode.Next = node;
                Last = node;
                Last.Previous = lastNode;
            }
        }

        public void AddBefore(MelNode node, int data)
        {
            MelNode newNode = new MelNode(data);

            MelNode previous = node.Previous;

            previous.Next = newNode;

            newNode.Next = node; 
        }


        public List<MelNode> Get_Middle_Node()
        {
            MelNode aheadNode = this.Head;
            MelNode behindNode = this.Head;
        

            while(aheadNode.Next!=null && aheadNode.Next.Next != null)
            {
                aheadNode = aheadNode.Next.Next;
                behindNode = behindNode.Next;
            }

            if(aheadNode.Next != null)
            {
                return new List<MelNode> { behindNode, behindNode.Next };
            }

            return new List<MelNode> { behindNode};
        }

    }



}
