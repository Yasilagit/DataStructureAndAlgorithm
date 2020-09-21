using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseArray();
            //UseLinkedList();
            //UseStack();
            //var expression = "[(<a+b)]>";
            //var isBalanced = BalancedExpression.IsBalancedExpression(expression);
            //if (isBalanced)
            //{
            //    Console.WriteLine("Balanced");
            //}
            //else
            //{
            //    Console.WriteLine("Not Balanced");
            //}
            UseArrayQueue();
            Console.ReadKey();

        }
        static void UseArray()
        {
            Array array = new Array(2);
            //array.Print();
            array.Insert(10);
            array.Insert(20);
            array.Insert(30);
            array.Insert(40);
            array.Insert(50);
            array.RemoveAt(4);
            array.Print();
            Console.WriteLine($"Index Of {array.IndexOf(30)}");
        }
        static void UseLinkedList()
        {
            var linkedList = new LinkedList();
            linkedList.AddLast(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);
            linkedList.AddLast(40);
            var iscontain = linkedList.Contains(20);
            var indexOf = linkedList.IndexOf(20);
            var size = linkedList.Size();
            var getArray = linkedList.ToArray();
            linkedList.Reverse();
        }
        static void UseStack()
        {
            var stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            Console.WriteLine(stack);
            stack.Pop();
            Console.WriteLine(stack);
            stack.Push(40);
            Console.WriteLine(stack.peek());
        }
        static void UseArrayQueue()
        {
            var arrayQueue = new ArrayQueue(5);
            arrayQueue.Enque(10);
            arrayQueue.Enque(20);
            arrayQueue.Enque(30);
            //arrayQueue.Enque(40);
            Console.WriteLine(arrayQueue);
            var deque = arrayQueue.Deque();
            Console.WriteLine(arrayQueue);
        }
    }
}
