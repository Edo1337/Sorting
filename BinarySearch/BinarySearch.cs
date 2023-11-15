using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    static class ArrayPlus
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        public static void Show(int[] array)
        {
            foreach (int i in array)
                Console.WriteLine(i);
        }

        /// <summary>
        /// Создает рандомный массив указанной длины
        /// </summary>
        /// <paramk name="arrayLenght"></param>
        /// <returns>Рандомный массив</returns>
        public static int[] ArrRnd(int arrayLenght)
        {
            int[] arr = new int[arrayLenght];
            Random random = new Random();

            for (int i = 0; i < arrayLenght - 1; i++)
                arr[i] = random.Next(0, 1000);

            return arr;
        }
    }
    static class BinarySearch
    {
        private static void ShowInfo(ref int searchedElement, ref int index, ref uint i)
        {
            Console.WriteLine($"Элемент массива {searchedElement} под индексом {index} найден за {i} циклов");
        }
        public static int Find(ref int[] array, ref int searchedElement)
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
    internal class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] arr = ArrayPlus.ArrRnd(100);

            Array.Sort(arr);

            ArrayPlus.Show(arr);

            Console.Write($"Какой элемент массива вы хотите найти: ");
            int elementForFind = int.Parse(Console.ReadLine());

            Console.WriteLine(BinarySearch.Find(ref arr, ref elementForFind));
        }
    }
}
