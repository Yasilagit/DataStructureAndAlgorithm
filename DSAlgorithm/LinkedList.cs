using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithm
{
    public class LinkedList
    {
        class Node
        {
            public int Item;
            public Node Next;

            public Node(int item)
            {
                this.Item = item;
            }

        }
        Node First, Last;

        public void AddFirst(int item)
        {
            var node = new Node(item);
            if (IsEmpty())
                First = Last = node;
            else
            {
                node.Next = First;
                First = node;
            }

        }
        public void AddLast(int item)
        {
            var node = new Node(item);
            if (IsEmpty())
                First = Last = node;
            else
            {
                Last.Next = node;
                Last = node;
            }
        }
        public void AddAt(int item, int index)
        {

        }
        public void RemoveFirst()
        {
            if (!IsEmpty())
            {
                var newFirst = First.Next;
                First = First.Next;
            }
        }
        public void RemoveLast()
        {
            if (!IsEmpty())
            {
                var previousNode = GetPreviousNode(Last);
                Last = previousNode;
                Last.Next = null;
            }
        }


        private Node GetPreviousNode(Node node)
        {
            Node current = First;
            while (current != null)
            {
                if (current.Next == node)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }
        public void RemoveAt(int index)
        {
        }
        public int IndexOf(int item)
        {
            int index = 0;
            Node current = First;
            while (current.Next != null)
            {
                if (current.Item == item)
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return index;
        }
        public bool Contains(int item)
        {
            Node current = First;
            while (current.Next != null)
            {
                if (current.Item == item)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        private bool IsEmpty()
        {
            return First == null;
        }

    }
}
