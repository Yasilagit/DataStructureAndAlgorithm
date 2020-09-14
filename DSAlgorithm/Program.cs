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
            Array array = new Array(2);
            //array.Print();
            array.Insert(10);
            array.Insert(20);
            array.Insert(30);
            array.Insert(40);
            array.Insert(50);
            array.RemoveAt(3);
            array.Print();

        }

        class Array
        {
            // Declare and initialize an array
            int[] array;
            int arraySize = 0;
            int count = 0;
            public Array(int size)
            {
                array = new int[size];

            }

            // insert element in to array

            public void Insert(int element)
            {
                if (count == 0)
                {
                    array[0] = element;
                }
                else if (count <= array.Length - 1)
                {
                    array[count] = element;
                }
                else
                {
                    int[] tempArray = new int[count + 1];
                    for (int i = 0; i < count; i++)
                    {
                        tempArray[i] = array[i];
                    }
                    tempArray[count] = element;
                    array = tempArray;
                }
                count++;
            }
            // remove element at specific location from array
            public void Print()
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
                Console.ReadKey();

            }
            public void RemoveAt(int index)
            {

                for (int i = index - 1; i < array.Length - 1; i++)
                {
                    array[i] = array[i + 1];
                }

                int[] tempArray = new int[count - 1];
                for (int i = 0; i < count - 1; i++)
                {
                    tempArray[i] = array[i];
                }

                array = tempArray;
            }

        }
    }
}
