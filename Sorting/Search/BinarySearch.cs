using System;

namespace SortAndSearch
{
    class BinarySearch : ISearch
    {
        public BinarySearch(int[] array, int searchedElement)
        {
            Search(array, searchedElement);
        }

        private void ShowResult(int searchedElement, int index, uint i)
        {
            Console.WriteLine($"Элемент массива {searchedElement} под индексом {index} найден за {i} циклов");
        }

        public int Search(int[] _array, int searchedElement)
        {
            var left = 0;
            var right = _array.Length - 1;

            uint i = default;

            while (left <= right)
            {
                var middle = (left + right) / 2;
                if (searchedElement > _array[middle])
                    left = middle + 1;
                else if (searchedElement < _array[middle])
                    right = middle - 1;
                else
                {
                    ShowResult(searchedElement, middle, i);
                    return middle;
                }
                i++;
            }
            return -1;
        }

    }
}
