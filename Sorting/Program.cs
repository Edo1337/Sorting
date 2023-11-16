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
            ////Сортировка
            //int[] nums = ArrayPlus.NewArrRnd(100);

            //var bubbleSort = new BubbleSort();
            //bubbleSort.Sort(ref nums);

            //ArrayPlus.Show(ref nums);

            ////Поиск
            //int[] arr = ArrayPlus.NewArrRnd(100);

            //var binarySearch = new BinarySearch();
            //bubbleSort.Sort(ref arr);

            //ArrayPlus.Show(ref arr);

            //Console.Write($"Какой элемент массива вы хотите найти: ");
            //int elementForSearch = int.Parse(Console.ReadLine());

            //binarySearch.Search(ref arr, ref elementForSearch);

            //Test
            int[] testArr = ArrayPlus.NewArrOneHund();
            ArrayPlus.Show(ref testArr);

            var bSort = new BubbleSort();
            bSort.Sort(ref testArr);
            ArrayPlus.Show(ref testArr);

            Console.Write($"Какой элемент массива вы хотите найти: ");
            int elementForSearch = int.Parse(Console.ReadLine());

            new BinarySearch(ref testArr, ref elementForSearch);
        }
    }
}
