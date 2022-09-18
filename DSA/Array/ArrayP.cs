using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    public static class ArrayP
    {
        /// <summary>
        /// Given an array, rotate the array to the right by k steps, where k is non-negative.
        /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/646/
        /// </summary>
        /// <param name="nums">The nums.</param>
        /// <param name="k">The k.</param>
        public static void Rotate(int[] nums, int k)
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

        public static int Reverse(int x)
        {
            int sum = 0;

            while (x != 0)
            {
                if (sum > Int32.MaxValue / 10 || sum < Int32.MinValue / 10)
                {
                    return 0;
                }
                else
                {
                    sum = sum * 10 + x % 10;
                    x /= 10;
                }
            }

            return sum;

        }

        /*
         * Input : arr = {2, 5, 6, 9},  m = 2 
           Output : 2
           Explanation: 
           subarrays are [2, 5, 6, 9] 
           and [5, 6, 9]
         * https://www.geeksforgeeks.org/number-subarrays-m-odd-numbers/
         */

        public static int SubArrayWithMOddNumbers(int[] a, int m)
        {
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                int counter = 0;
                for (int j = i; j < a.Length; j++)
                {
                    if(a[j] % 2 != 0)
                    {
                        counter++;
                    }

                    if(counter == m)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public static void RemoveDuplicateFromSortedArray(int[] array)
        {
            // 1 1 2 3

            if (array.Length <= 1)
                return;

            int slow = 0;
            int fast = 1;

            while(slow < array.Length - 1 && fast < array.Length)
            {
                if(slow != fast)
                {
                    array[slow + 1] = array[fast];
                    slow++;
                }
                fast++;
            }
        }

        public static int GetMaximumOfKConsecutive(int[] array, int k)
        {
            if (k > array.Length)
                return -1;

            int sum = 0;
            int maxSum = 0;

            for(int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
                if (i == k - 1)
                    maxSum = sum;

                if(i >= k)
                {
                    sum = sum - array[i - k];
                    maxSum = Math.Max(sum, maxSum);
                }
            }
            return maxSum;
        }
    }
}
