using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingDemos
{
    class SelectionSortDemo
    {
        static void Main()
        {
            int[] num = new int[] { 12, 4, 25, 10, 2, 13, 18, 80 };

            Console.WriteLine("Elements before Sorting");
            PrintElements(num);
            SelectionSort(num);
            Console.WriteLine("Elements after Sorting");
            PrintElements(num);
        }
        static void PrintElements(int[] num)
        {
            foreach (int x in num)
                Console.WriteLine(x);
        }
        static void SelectionSort(int[] num)
        {
            int temp;
            for(int i=0;i<num.Length-1;i++)
            {
               for(int j=i+1; j<num.Length;j++)
                {
                    if(num[i] > num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
        }

    }
}
