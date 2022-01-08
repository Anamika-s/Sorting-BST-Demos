using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingDemos
{
    class MergeSortDemo
    {
        static void Main()
        {
            int[] array1 = new int[] { 4, 14, 25, 40, 75, 83, 88, 92 };
            int[] array2 = new int[] { 1, 3, 15, 18, 90 };
            int[] sortedArray = new int[(array1.Length + array2.Length)-1];
            Console.WriteLine("Elements before Sorting");
           // PrintElements(array1, array2);
            MergeSort(array1,array2, sortedArray);
            Console.WriteLine("Elements after Sorting");
            PrintElements(sortedArray);
        }
        static void PrintElements(int[] num)
        {
            foreach (int x in num)
                Console.WriteLine(x);
        }
        static void MergeSort(int[] array1, int [] array2 , int [] sortedArray)
        {
            int i=0, j=0, k=0;
            Console.WriteLine(array1.Length);
            Console.WriteLine(array2.Length);
           while(i<array1.Length && j < array2.Length)
            {
                if(array1[i] > array2[j])
                {
                    sortedArray[k] = array2[j];
                    j++;
                    k++;
                }
                else
                {
                    sortedArray[k] = array1[i];
                    i++;
                    k++;
                }

            }
            Console.WriteLine("i is " + i);
            Console.WriteLine("j is " + j);
            if(i==array1.Length-1 && j < array2.Length)
            {
                 
                while(j<array2.Length)
                {
                    sortedArray[k] = array2[j];
                    j++;
                    k++;
                }
            }
            else if (i < array1.Length-1 && j == array2.Length)
            {

                while (i < array1.Length)
                {
                    sortedArray[k] = array1[i];
                    i++;
                    k++;
                }
            }
        }

    }
}
