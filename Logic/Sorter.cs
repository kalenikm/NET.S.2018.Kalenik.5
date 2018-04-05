using System;

namespace Logic
{
    public static class Sorter
    {
        public enum Order
        {
            Ascending,
            Descending
        }
        public enum OrderByTag
        {
            Lenght,
            Min,
            Max
        }

        /// <summary>
        /// Sorts jagged array by lenght.
        /// </summary>
        /// <param name="matrix">Jagged array to sort.</param>
        /// <param name="tag">Tag to order by.</param>
        /// <param name="order">Order of sorting.</param>
        public static void BubbleSort(this int[][] matrix, OrderByTag tag, Order order)
        {
            if(matrix == null)
                throw new ArgumentNullException($"Array {nameof(matrix)} is null.");
            if(matrix.Length == 0)
                throw new ArgumentException($"Array {nameof(matrix)} is empty.");

            switch (tag)
            {
                case OrderByTag.Lenght:
                    matrix.BubbleSort(CompareByLength, order);
                    break;
                case OrderByTag.Min:
                    matrix.BubbleSort(CompareByMinElement, order);
                    break;
                case OrderByTag.Max:
                    matrix.BubbleSort(CompareByMaxElement, order);
                    break;
                default:
                    throw new ArgumentException(nameof(tag));
            }

        }


        private static void BubbleSort(this int[][] matrix, Func<int[], int[], int> func, Order order)
        {
            if (matrix == null)
                throw new ArgumentNullException($"Array {nameof(matrix)} is null.");
            if (matrix.Length == 0)
                throw new ArgumentException($"Array {nameof(matrix)} is empty.");

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length - i - 1; j++)
                {
                    if (func(matrix[j], matrix[j + 1]) > 0 == (order == Order.Ascending))
                        Swap(ref matrix[j], ref matrix[j + 1]);
                }
            }
        }

        private static int CompareByLength(int[] firstArr, int[] secondArr)
        {
            return firstArr.Length.CompareTo(secondArr.Length);
        }

        private static int CompareByMaxElement(int[] firstArr, int[] secondArr)
        {
            return FindMax(firstArr).CompareTo(FindMax(secondArr));
        }

        private static int CompareByMinElement(int[] firstArr, int[] secondArr)
        {
            return FindMin(firstArr).CompareTo(FindMin(secondArr));
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
    }
}
