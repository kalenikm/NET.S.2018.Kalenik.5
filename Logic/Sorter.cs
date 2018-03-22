using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class Sorter
    {
        public enum OrderBy
        {
            Ascending,
            Descending
        }
        public static void BubbleSort(this int[][] matrix, Func<int[],int> func, OrderBy order)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length - i - 1; j++)
                {
                    if (func(matrix[j]) > func(matrix[j + 1]))
                        Swap(matrix[j], matrix[j+1]);
                }
            }
        }

        public static void Swap(int[] a, int[] b)
        {
            var buff = a;
            a = b;
            b = buff;
        }

        public static int FindMin(int[] array)
        {
            int min = Int32.MaxValue;
            foreach (var num in array)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }

        public static int FindMax(int[] array)
        {
            int max = Int32.MinValue;
            foreach (var num in array)
            {
                if (num < max)
                    max = num;
            }
            return max;
        }

        public static int GetLength(int[] array)
        {
            return array.Length;
        }
    }
}
