using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingDemos
{
    class BubbleSortDemo
    {
        public static void Main()
        {
            int[] num = new int[] { 12, 4, 25, 10, 2, 13, 18, 80 };
            Console.WriteLine("Elements before Sorting");
            PrintElements(num);
            BubbleSort(num);
            Console.WriteLine("Elements after Sorting");
            PrintElements(num);

        }
        static void PrintElements(int[] num)
        {
            foreach(int x in num)
                Console.WriteLine(x);
        }

        static void BubbleSort(int [] num)
        {

            int n = num.Length;
            int temp;
            for (int i = 0; i < n - 1;i++)
            {
                for(int j=0;j<n-i-1; j++)
                {
                    if(num[j] > num[j+1])
                    {
                        temp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = temp;
                    }
                }
            }


        }
    }
}
