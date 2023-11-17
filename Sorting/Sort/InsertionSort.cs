using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndSearch
{
    internal class InsertionSort : ISort
    {
        /// <summary>
        /// В алгоритме Insertion sort элементы входной последовательности просматриваются по одному, и каждый новый поступивший элемент размещается в подходящее место среди ранее упорядоченных элементов.
        ///Временная сложность алгоритма — O(n2).
        /// </summary>
        /// <param Массив></param>
        /// <returns>Отсортированный массив</returns>
        public int[] Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }

            return arr;
        }
    }
}
