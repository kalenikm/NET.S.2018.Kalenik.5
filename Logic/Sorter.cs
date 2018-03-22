using System;

namespace Logic
{
    public static class Sorter
    {
        public enum OrderBy
        {
            Ascending,
            Descending
        }
        /// <summary>
        /// Sorts jagged array by value that return <paramref name="func"/>.
        /// </summary>
        /// <param name="matrix">Jagged array to sort.</param>
        /// <param name="func">Delegate that returns value that will used to sort array.</param>
        /// <param name="order">Order of sorting.</param>
        public static void BubbleSort(this int[][] matrix, Func<int[],int> func, OrderBy order)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length - i - 1; j++)
                {
                    if (func(matrix[j]) > func(matrix[j + 1]) == (order == OrderBy.Ascending))
                        Swap(ref matrix[j], ref matrix[j + 1]);
                }
            }
        }
        
        private static void Swap(ref int[] a, ref int[] b)
        {
            var buff = a;
            a = b;
            b = buff;
        }

        /// <summary>
        /// Finds minimal number in int array.
        /// </summary>
        /// <param name="array">Int array.</param>
        /// <returns>Minimal number.</returns>
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

        /// <summary>
        /// Finds maximum number in int array.
        /// </summary>
        /// <param name="array">Int array.</param>
        /// <returns>Maximum number.</returns>
        public static int FindMax(int[] array)
        {
            int max = Int32.MinValue;
            foreach (var num in array)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }

        /// <summary>
        /// Returns lenght of int array.
        /// </summary>
        /// <param name="array">Int array.</param>
        /// <returns>Lenght of <paramref name="array"/>.</returns>
        public static int GetLength(int[] array)
        {
            return array.Length;
        }
    }
}
