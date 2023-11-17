using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArr = ArrayPlus.NewArrRnd();
            ArrayPlus.Show(testArr);

            Console.WriteLine();
            var insertionSort = new InsertionSort();
            insertionSort.Sort(testArr);
            ArrayPlus.Show(testArr);

            Console.Write($"Какой элемент массива вы хотите найти: ");
            int elementForSearch = int.Parse(Console.ReadLine());

            new BinarySearch(testArr, elementForSearch);
        }
    }
}
