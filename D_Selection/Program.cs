using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Selection
{
    class Program
    {
        public static void Quicksort(int[] arr, int p, int r)
        {
            if (p < r)
            {
                int q = Partation(arr, p, r);
                Quicksort(arr, p, q - 1);
                Quicksort(arr, q + 1, r);
            }
        }

        public static int Partation(int[] arr, int p, int r)
        {
            int temp;
            int x;
            x = arr[r];
            int i;
            i = p - 1;
            for (int j = p; j <= r - 1; j++)
            {
                if (arr[j] <= x)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            temp = arr[i + 1];
            arr[i + 1] = x;
            arr[r] = temp;

            return i + 1;
        }

        public static int Select(int[] arr, int p, int r, int i)
        {
            if (p == r)
            {
                return arr[p];
            }
            int q = Partation(arr, p, r);

            int k = q - p + 1;
            if (i == k)
                return arr[q];

            if (i <k) return Select(arr, p, q-1, i);

            else return Select(arr, q+1, r, i - k);


        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 1, 8, 4, 9, 2, 7 };

            //Quicksort(arr, 0, arr.Length - 1);

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

          int i=  Select(arr, 0, arr.Length - 1, 6);
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
