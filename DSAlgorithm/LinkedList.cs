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
        int size = 0;
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
            size++;

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
            size++;
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
                size--;
            }
        }
        public void RemoveLast()
        {
            if (!IsEmpty())
            {
                var previousNode = GetPreviousNode(Last);
                Last = previousNode;
                Last.Next = null;
                size--;
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
        public int Size()
        {
            return size;
        }
        public int[] ToArray()
        {
            int[] array = new int[size];
            int i = 0;

            var current = First;
            while (current != null)
            {
                array[i++] = current.Item;
                current = current.Next;
            }

            return array;
        }
        public void Reverse()
        {
            //[10-> 20 -> 30-> 40]
            // p     c     n

            var previous = First;
            var current = First.Next;
            while (current != null)
            {
                var next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }
            Last = First;
            Last.Next = null;
            First = previous;
        }


    }
}
