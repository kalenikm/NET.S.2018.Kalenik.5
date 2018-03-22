using NUnit.Framework;


namespace Logic.Tests
{
    [TestFixture]
    public class SorterTests
    {
        [TestCase]
        public void TestSorter_SortByLenght_Ascending()
        {
            int[][] matr =
            {
                new[] {1, 2, 3, 4, 5},
                new[] {1, 2, 4, 7, 1, 7, 2, 7, 3},
                new[] {1, 4, 6}
            };
            int[][] res =
            {
                new[] {1, 4, 6},
                new[] {1, 2, 3, 4, 5},
                new[] {1, 2, 4, 7, 1, 7, 2, 7, 3}
            };
            matr.BubbleSort(Sorter.GetLength, Sorter.OrderBy.Ascending);
            for (int i = 0; i < res.Length; i++)
            {
                for (int j = 0; j < res[i].Length; j++)
                {
                    Assert.AreEqual(res[i][j], matr[i][j]);
                }
            }
        }

        [TestCase]
        public void TestSorter_SortByLenght_Descending()
        {
            int[][] matr =
            {
                new[] {1, 2, 3, 4, 5},
                new[] {1, 2, 4, 7, 1, 7, 2, 7, 3},
                new[] {1, 4, 6}
            };
            int[][] res =
            {
                new[] {1, 2, 4, 7, 1, 7, 2, 7, 3},
                new[] {1, 2, 3, 4, 5},
                new[] {1, 4, 6}
            };
            matr.BubbleSort(Sorter.GetLength, Sorter.OrderBy.Descending);
            for (int i = 0; i < res.Length; i++)
            {
                for (int j = 0; j < res[i].Length; j++)
                {
                    Assert.AreEqual(res[i][j], matr[i][j]);
                }
            }
        }

        [TestCase]
        public void TestSorter_SortByMin_Ascending()
        {
            int[][] matr =
            {
                new[] {34, 11, 16, 54, 78},
                new[] {7, 122, 55, 725, 73},
                new[] {324, 672, 9, 13, 45}
            };
            int[][] res =
            {
                new[] {7, 122, 55, 725, 73},
                new[] {324, 672, 9, 13, 45},
                new[] {34, 11, 16, 54, 78}
            };
            matr.BubbleSort(Sorter.FindMin, Sorter.OrderBy.Ascending);
            for (int i = 0; i < res.Length; i++)
            {
                for (int j = 0; j < res[i].Length; j++)
                {
                    Assert.AreEqual(res[i][j], matr[i][j]);
                }
            }
        }

        [TestCase]
        public void TestSorter_SortByMin_Descending()
        {
            int[][] matr =
            {
                new[] {34, 11, 16, 54, 78},
                new[] {7, 122, 55, 725, 73},
                new[] {324, 672, 9, 13, 45}
            };
            int[][] res =
            {
                new[] {34, 11, 16, 54, 78},
                new[] {324, 672, 9, 13, 45},
                new[] {7, 122, 55, 725, 73}
            };
            matr.BubbleSort(Sorter.FindMin, Sorter.OrderBy.Descending);
            for (int i = 0; i < res.Length; i++)
            {
                for (int j = 0; j < res[i].Length; j++)
                {
                    Assert.AreEqual(res[i][j], matr[i][j]);
                }
            }
        }

        [TestCase]
        public void TestSorter_SortByMax_Ascending()
        {
            int[][] matr =
            {
                new[] {34, 11, 16, 54, 78},
                new[] {7, 122, 55, 725, 73},
                new[] {324, 78, 9, 13, 45}
            };
            int[][] res =
            {
                new[] {34, 11, 16, 54, 78},
                new[] {324, 78, 9, 13, 45},
                new[] {7, 122, 55, 725, 73}
            };
            matr.BubbleSort(Sorter.FindMax, Sorter.OrderBy.Ascending);
            for (int i = 0; i < res.Length; i++)
            {
                for (int j = 0; j < res[i].Length; j++)
                {
                    Assert.AreEqual(res[i][j], matr[i][j]);
                }
            }
        }

        [TestCase]
        public void TestSorter_SortByMax_Descending()
        {
            int[][] matr =
            {
                new[] {34, 11, 16, 54, 78},
                new[] {7, 122, 55, 725, 73},
                new[] {324, 78, 9, 13, 45}
            };
            int[][] res =
            {
                new[] {7, 122, 55, 725, 73},
                new[] {324, 78, 9, 13, 45},
                new[] {34, 11, 16, 54, 78}
            };
            matr.BubbleSort(Sorter.FindMax, Sorter.OrderBy.Descending);
            for (int i = 0; i < res.Length; i++)
            {
                for (int j = 0; j < res[i].Length; j++)
                {
                    Assert.AreEqual(res[i][j], matr[i][j]);
                }
            }
        }
    }
}
