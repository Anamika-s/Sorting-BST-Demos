using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingDemos
{
    class InsertionSortDemo
    {
        static void Main()
        {
            int[] num = new int[] { 12, 4, 25, 10, 2, 13, 18, 80 };

            Console.WriteLine("Elements before Sorting");
            PrintElements(num);
            InsertionSort(num);
            Console.WriteLine("Elements after Sorting");
            PrintElements(num);
        }
        static void PrintElements(int[] num)
        {
            foreach (int x in num)
                Console.WriteLine(x);
        }
        static void InsertionSort(int[] num)
        {
            
            int x, j = 0;
            for (int i = 1; i < num.Length; i++)
            {
                x = num[i];
                j = i - 1;
                while (j >= 0 && num[j] > x)
                {
                    num[j + 1] = num[j];
                    j = j - 1;
                }
                num[j + 1] = x;
            }

        }
    }
}
