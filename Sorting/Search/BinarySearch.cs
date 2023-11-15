using Sorting.Search;
using System;

namespace SortAndSearch
{
    class BinarySearch: ISearch
    {
        private void ShowInfo(ref int searchedElement, ref int index, ref uint i)
        {
            Console.WriteLine($"Элемент массива {searchedElement} под индексом {index} найден за {i} циклов");
        }
        public int Search(ref int[] array, ref int searchedElement)
        {
            var left = 0;
            var right = array.Length - 1;

            uint i = default;

            while (left <= right)
            {
                var middle = (left + right) / 2;
                if (searchedElement > array[middle])
                    left = middle + 1;
                else if (searchedElement < array[middle])
                    right = middle - 1;
                else
                {
                    ShowInfo(ref searchedElement, ref middle, ref i);
                    return middle;
                }
                i++;
            }
            return -1;
        }

    }
}
