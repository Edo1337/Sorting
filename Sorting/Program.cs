using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndSearch
{
    static class ArrayPlus
    {
        /// <summary>
        /// Дает представление заданному массиву
        /// </summary>
        /// <param name="array"></param>
        /// <summary>
        public static void Show(ref int[] array)
        {
            foreach (int i in array)
                Console.WriteLine(i);
        }

        /// <summary>
        /// Создает рандомный массив указанной длины
        /// </summary>
        /// <param name="arrayLenght"></param>
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


    internal class SortPlus
    {

        static void Main(string[] args)
        {
            int[] nums = new int[34] { 214, 532, 124, 531, 312, 53, 7, 18, 7, 57, 5, 48, 86, 68, 68, 3, 11, 63, 5, 7, 56, 3, 6, 6, 89, 9, 34, 5, 8, 7, 3, 45, 3, 76 };

            var sort = new BubbleSort();

            sort.Sort(ref nums);

            ArrayPlus.Show(ref nums);

            int[] arr = ArrayPlus.ArrRnd(100);

            Array.Sort(arr);

            ArrayPlus.Show(ref arr);

            Console.Write($"Какой элемент массива вы хотите найти: ");
            int elementForFind = int.Parse(Console.ReadLine());

            Console.WriteLine(BinarySearch.Find(ref arr, ref elementForFind));
        }


    }
}
