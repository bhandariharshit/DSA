using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    public class ArrayP
    {
        /// <summary>
        /// Given an array, rotate the array to the right by k steps, where k is non-negative.
        /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/646/
        /// </summary>
        /// <param name="nums">The nums.</param>
        /// <param name="k">The k.</param>
        public void Rotate(int[] nums, int k)
        {

            k = k % nums.Length;

            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);
        }

        static void Reverse(int[] nums, int start, int end)
        {
            int temp = 0;

            while (start < end)
            {
                temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }

        }

        static void MultiDArray()
        {
            int[,] arr = new int[2, 2];
            int[] a = new int[5];
            a[1] = 1;
            arr[0, 0] = 1;

            for(int i=0; i<2; i++)
            {
                arr[i, i] = 1;
            }
        }
    }
}
