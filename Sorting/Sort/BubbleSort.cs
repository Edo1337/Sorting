using System;

namespace SortAndSearch
{
    /// <summary>
    /// Сортровка пузырьком. n^2
    /// </summary>
    public class BubbleSort : ISort
    {
        private void Swap(ref int e1, ref int e2)
        {
            int temp = e1;
            e1 = e2;
            e2 = temp;
        }

        public int[] Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }

            return arr;
        }
    }
}
