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
        /// Sorts jagged array by lenght.
        /// </summary>
        /// <param name="matrix">Jagged array to sort.</param>
        /// <param name="order">Order of sorting.</param>
        public static void BubbleSortByLenght(this int[][] matrix, OrderBy order)
        {
            if(matrix == null)
                throw new ArgumentNullException($"Array {nameof(matrix)} is null.");
            if(matrix.Length == 0)
                throw new ArgumentException($"Array {nameof(matrix)} is empty.");

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length - i - 1; j++)
                {
                    if (GetLenght(matrix[j]) > GetLenght(matrix[j + 1])== (order == OrderBy.Ascending))
                        Swap(ref matrix[j], ref matrix[j + 1]);
                }
            }
        }

        /// <summary>
        /// Sorts jagged array by min value of array.
        /// </summary>
        /// <param name="matrix">Jagged array to sort.</param>
        /// <param name="order">Order of sorting.</param>
        public static void BubbleSortByMin(this int[][] matrix, OrderBy order)
        {
            if (matrix == null)
                throw new ArgumentNullException($"Array {nameof(matrix)} is null.");
            if (matrix.Length == 0)
                throw new ArgumentException($"Array {nameof(matrix)} is empty.");

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length - i - 1; j++)
                {
                    if (FindMin(matrix[j]) > FindMin(matrix[j + 1]) == (order == OrderBy.Ascending))
                        Swap(ref matrix[j], ref matrix[j + 1]);
                }
            }
        }

        /// <summary>
        /// Sorts jagged array by max value of array.
        /// </summary>
        /// <param name="matrix">Jagged array to sort.</param>
        /// <param name="order">Order of sorting.</param>
        public static void BubbleSortByMax(this int[][] matrix, OrderBy order)
        {
            if (matrix == null)
                throw new ArgumentNullException($"Array {nameof(matrix)} is null.");
            if (matrix.Length == 0)
                throw new ArgumentException($"Array {nameof(matrix)} is empty.");

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length - i - 1; j++)
                {
                    if (FindMax(matrix[j]) > FindMax(matrix[j + 1]) == (order == OrderBy.Ascending))
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

        private static int FindMin(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException($"Array {nameof(array)} is null.");
            if (array.Length == 0)
                return Int32.MaxValue;

            int min = Int32.MaxValue;
            foreach (var num in array)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }

        private static int FindMax(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException($"Array {nameof(array)} is null.");
            if (array.Length == 0)
                return Int32.MinValue;

            int max = Int32.MinValue;
            foreach (var num in array)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }

        private static int GetLenght(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException($"Array {nameof(array)} is null.");

            return array.Length;
        }
    }
}
