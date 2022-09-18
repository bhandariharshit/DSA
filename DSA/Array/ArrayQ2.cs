using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array1
{
    class ArrayQ2
    {

        //[1,-1,2,-2,4,-4,3] = 3

        //[1,-1,2,-2,-4,-3,3] = -4
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A == null || A.Length == 0)
            {
                return 1;
            }

            System.Array.Sort(A);

            for (int i = 0; i < A.Length; i++)
            {
                if (i < A.Length - 1 && A[i] != A[i + 1] && A[i] + 1 != A[i + 1] && A[i] > 0)
                {
                    return A[i] + 1;
                }
            }

            if (A[A.Length - 1] > 0)
            {
                return A[A.Length - 1] + 1;
            }
            else
                return 1;
        }

        public int NumberWhichDoesnothaveaCorrrepondingNegative(int[] a)
        {
            List<int> lstNegative = new List<int>();
            System.Array.Sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    lstNegative.Add(a[i]);
                }
                else
                {
                    if (!lstNegative.Contains(-(a[i])))
                    {
                        return a[i];
                    }
                }
            }

            return 0;
        }
        public int NumberWhichDoesnothaveaCorrrepondingNegative1(int[] a)
        {
            List<int> lst = new List<int>();

            for (int i = 0; i < a.Length; i++)
            {
                bool check = false;
                if (!lst.Contains(Math.Abs(a[i])))
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == -a[j] || -a[i] == a[j])
                        {
                            lst.Add(Math.Abs(a[i]));
                            check = true;
                            break;
                        }
                        else
                        {
                            check = false;
                        }
                    }
                    if (!check)
                    {
                        return a[i];
                    }
                }
            }
            return 0;
        }

        public int FindMissingNumber(int[] array, int n)
        {
            int missingNumber = array[0];

            for (int i = 1; i < n; i++)
            {
                missingNumber = missingNumber ^ i ^ array[i];
            }

            return missingNumber;
        }

        public void TwoDArray()
        {
            int[,] arr = new int[,] { { 1, 2, 3, 5 }, { 2, 4, 8, 9 }, { 5, 6, 6, 10 } };
            int row = arr.GetLength(0);
            int column = arr.GetLength(1);
            int length = arr.Length;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(arr[i, j]);
                }
            }
        }

        public void JaggedArray()
        {
            int[][] jagged = new int[2][] { new int[1] { 1 }, new int[2] { 2, 3 } };

            int rows = jagged.Length;
            
            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
