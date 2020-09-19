using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithm
{
    public class Stack<T>
    {
        T[] stack = new T[1];
        int count = 0;
        public void Push(T item)
        {
            if (count > stack.Length - 1)
            {
                T[] tmpStack = new T[count * 2];
                for (int i = 0; i < stack.Length; i++)
                {
                    tmpStack[i] = stack[i];
                }
                tmpStack[count] = item;
                stack = tmpStack;
                count++;
            }
            else
            {
                stack[count++] = item;
            }

        }
        public T Pop()
        {
            count--;
            return stack[count];
        }
        public int peek()
        {
            return 0;
            //return stack[count - 1];
        }
        public bool IsEmpty()
        {
            return count == 0;

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append($" {stack[i]}");
            }
            return sb.ToString();
        }

    }
}

