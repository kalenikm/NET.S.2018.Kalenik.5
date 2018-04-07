using System;
using System.Collections;
using System.Collections.Generic;

namespace Logic
{
    public static class DelegateInInterface
    {
        public static void BubbleSort(this int[][] matr, IComparer<int[]> copmarer)
        {
            BubbleSort(matr, copmarer.Compare);
        }

        private static void BubbleSort(int[][] matrix, Comparison<int[]> comp)
        {
            if (matrix == null)
                throw new ArgumentNullException($"Array {nameof(matrix)} is null.");
            if (matrix.Length == 0)
                throw new ArgumentException($"Array {nameof(matrix)} is empty.");

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length - i - 1; j++)
                {
                    if (comp(matrix[j], matrix[j + 1]) > 0)
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
    }
}