using System;

namespace BubbleSort
{
    internal class BubbleSort
    {
        private static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        public static int[] BubbleSort(ref int[] arr)
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

        static void Main(string[] args)
        {
            int[] nums = new int[34] { 214, 532, 124, 531, 312, 53, 7, 18, 7, 57, 5, 48, 86, 68, 68, 3, 11, 63, 5, 7, 56, 3, 6, 6, 89, 9, 34, 5, 8, 7, 3, 45, 3, 76 };

            BubbleSort(ref nums);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
