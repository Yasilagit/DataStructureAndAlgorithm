using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithm
{
    class ArrayQueue
    {

        int[] array;
        int count = 0;
        int front = 0;
        int rear = 0;

        public ArrayQueue(int capacity)
        {
            array = new int[capacity];
        }
        public void Enque(int item)
        {
            if (IsFull())
            {
                throw new Exception("Queue Full");
            }
            else
            {
                array[count++] = item;
                rear = (rear + 1) % array.Length;
            }

        }
        public int Deque()
        {
            count--;
            var tmpFirst = front;
            array[tmpFirst] = 0;
            front = (front+1) % array.Length;
            return array[tmpFirst];
        }
        public int Peek()
        {
            return array[front];
        }
        public bool IsEmpty()
        {
            return count == 0;
        }
        public bool IsFull()
        {
            return count == array.Length;

        }
        public override string ToString()
        {
            return string.Join(",", array);
        }
    }
}
