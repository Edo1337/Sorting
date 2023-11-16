using System;

namespace SortAndSearch
{
    /// <summary>
    /// Предоставляет методы для создания и представления
    /// </summary>
    internal static class ArrayPlus
    {
        /// <summary>
        /// Дает представление заданному массиву
        /// </summary>
        /// <param name="array"></param>
        public static void Show(ref int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i);
                if (i != array[array.Length - 1])
                    Console.Write(", ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Создает рандомный массив указанной длины 
        /// </summary>
        /// <param name="arrayLenght"></param>
        /// <returns>Рандомный массив</returns>
        public static int[] NewArrRnd(int arrayLenght = 100, int min = 0, int max = 1000)
        {
            int[] arr = new int[arrayLenght];
            Random random = new Random();

            for (int i = 0; i < arrayLenght; i++)
                arr[i] = random.Next(min, max);

            return arr;
        }

        /// <summary>
        /// Создает массив длины равной 100 от 0 до 99 
        /// </summary>
        /// <returns>Массив от 0 до 99</returns>
        public static int[] NewArrOneHund()
        {
            int[] arr = new int[100];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = i;

            return arr;
        }

    }
}
