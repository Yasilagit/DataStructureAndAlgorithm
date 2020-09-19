using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithm
{
    public class Stack
    {
        int[] stack = new int[1];
        int count = 0;
        public void Push(int item)
        {
            if (count > stack.Length - 1)
            {
                int[] tmpStack = new int[count * 2];
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
        public void Pop()
        {
            count--;
        }
        public int peek()
        {
            return stack[count - 1];
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

