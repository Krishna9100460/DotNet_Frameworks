using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_Sharp.LinearData_Structure
{
    public class ArrayDSA
    {
        public void OneDimensionalArray()
        {
            Console.WriteLine("Enter Array size:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter Array Elements equal to size:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("One Dimensional Array output:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            int largest = 0;
            //Finding the largest element in an array
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] > largest)
                {
                    largest = arr[j];
                }
            }
            Console.WriteLine("Largest Element is:" + largest);

            Console.WriteLine();
            //Searching an element in an array
            Console.WriteLine("Enter Element to search:");
            int elementToFind = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == elementToFind)
                {
                    Console.WriteLine("Element found at index:" + i);
                    break;
                }
            }
            //Deleting an element in an array
            Console.WriteLine("Enter Element to delete:");
            int elementToDelete = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == elementToDelete)
                {
                    arr[i] = 0;
                    break;
                }
            }
            /*Console.WriteLine("less to greater deleting output:");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("greater to less deleting output:");
            for (int i = arr.Length - 1; i > 0; i--)
            {
                for (int j = arr.Length - i - 1; j >0; j--)
                {
                    if (arr[j] > arr[j - 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }*/


        }


        public void TwoDimensionalArray()
        {
            Console.WriteLine("Enter Row size:");
            int rowSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter column size :");
            int columnSize = Convert.ToInt32(Console.ReadLine());

            int[,] twoDimensionalArray = new int[rowSize, columnSize];
            Console.WriteLine("Enter 2D Array Elements:");
            for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
                {
                    twoDimensionalArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Output of two dimensional array");
            for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
                {
                    Console.Write(twoDimensionalArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void JaggedArray()
        {
            int[][] jaggedArray = new int[3][];
            Console.WriteLine("Enter jagged Array Elements:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = new int[i + 1];
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"Element {i}, {j}: ");
                    jaggedArray[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Output of jagged array");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
