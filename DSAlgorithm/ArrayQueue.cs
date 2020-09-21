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
        int first = 0;
        int last = -1;

        public ArrayQueue(int capacity)
        {
            array = new int[capacity];
        }
        public void Enque(int item)
        {
            if (IsFull())
            {
                throw new Exception("Queue Full");
                //var tempArray = new int[count * 2];
                //for (int i = 0; i < count; i++)
                //{
                //    tempArray[i] = array[i];
                //}
                //tempArray[count] = item;
                //array = tempArray;
                //count++;
                //last++;
            }
            else
            {
                array[count++] = item;
                last++;
            }

        }
        public int Deque()
        {
            count--;
            var tmpFirst = first;
            array[tmpFirst] = 0;
            first++;
            return array[tmpFirst];
        }
        public int Peek()
        {
            return array[first];
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
