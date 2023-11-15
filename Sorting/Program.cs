using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class SortPlus
    {
        static void Main(string[] args)
        {
            int[] nums = new int[34] { 214, 532, 124, 531, 312, 53, 7, 18, 7, 57, 5, 48, 86, 68, 68, 3, 11, 63, 5, 7, 56, 3, 6, 6, 89, 9, 34, 5, 8, 7, 3, 45, 3, 76 };

            var sort = new BubbleSort();

            BubbleSort.BubbleSort.Sort(nums, sort);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }

    }
}
