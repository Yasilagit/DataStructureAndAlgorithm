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
            //Array array = new Array(2);
            ////array.Print();
            //array.Insert(10);
            //array.Insert(20);
            //array.Insert(30);
            //array.Insert(40);
            //array.Insert(50);
            //array.RemoveAt(4);
            //array.Print();
            //Console.WriteLine($"Index Of {array.IndexOf(30)}");

            var linkedList = new LinkedList();
            linkedList.AddLast(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);
            linkedList.AddFirst(40);
            var iscontain = linkedList.Contains(20);
            var indexOf = linkedList.IndexOf(20);
            linkedList.RemoveFirst();
            linkedList.RemoveLast();
            Console.ReadKey();

        }

    }
}
