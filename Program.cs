using System;
using NUnit.Framework;
using SortingMethodsLib;

namespace NET.S._2020.Aristova._1
{
    /// <summary>
    /// Contans tests for sorting methods
    /// </summary>
    class Program
    {
        private static int[] TestData = new[] { 5, 1, 9, 2, 12135, 12, 616, 5, 2 };

        [Test]
        public void Merge()
        {
            int[] array = TestData;
            MergeSort.Sort(array);
            Assert.IsTrue(CheckSorted(array));
            Assert.Catch(typeof(ArgumentNullException), () => MergeSort.Sort(null));
        }

        [Test]
        public void Quick()
        {
            int[] array = TestData;
            QuickSort.Sort(array);
            Assert.IsTrue(CheckSorted(array));
            Assert.Catch(typeof(ArgumentNullException), () => QuickSort.Sort(null));
        }

        /// <summary>
        /// Check for array sorting
        /// </summary>
        /// <param name="array">Sorting array</param>
        /// <returns>
        /// True - if the array is sorted
        /// False - if the array isn't soretd
        /// </returns>
        private bool CheckSorted(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i+1])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
