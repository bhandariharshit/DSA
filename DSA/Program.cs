﻿using DSA.Array1;
using DSA.Array;
using DSA.LinkedList;
using DSA.Tree;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using String = DSA.Strings.String;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayQ2 arrayQ2 = new ArrayQ2();
            arrayQ2.JaggedArray();
            string st = "This is an interview question";
            Console.WriteLine(String.ReplaceCharInString(new char[0], ' ', "SPACE"));
            double d = 1.0;
            bool check = String.ValidSubstring("for", "geefksforgeeks");
            String.LongestCommonPrefix(new string[] { "flower", "flow", "flight" });
            arrayQ2.FindMissingNumber(new int[] { 1, 2, 4, 5 }, 5);

            int remainingnum = arrayQ2.NumberWhichDoesnothaveaCorrrepondingNegative1(new int[] { 1, -1, 2, -2, 4, -4, 3 });

            arrayQ2.solution(new int[] { 1, 3, 2, 4, 5 });

            Recurssion recurssion = new Recurssion();
            recurssion.abs = 10;
            recurssion.Recurse(0);
            int prop = recurssion.MyProperty;
            string s = "jell";
            string sb = String.ConvertToBinary(5);

            int[] nums = { 1, 2, 3, 2, 3 };

            Console.WriteLine(2 ^ 3);

            int unique = 0;
            foreach (int i in nums)
            {
                unique ^= i;
            }

            #region LinkedList

            LinkedListT linkedListT = new LinkedListT(1);
            linkedListT.head.Next = new LinkedListNode(1);
            linkedListT.head.Next.Next = new LinkedListNode(2);

            LinkedListNode head = linkedListT.DeleteDuplicates(linkedListT.head);

            #endregion

            #region String

            string read = Console.ReadLine();

            #region Count of alphabet, integer and string
            int alph = 0; int num = 0; int special = 0;

            for (int i = 0; i < read.Length; i++)
            {
                if ((read[i] >= 'a' && read[i] <= 'z') || (read[i] >= 'A' && read[i] <= 'Z'))
                {
                    alph++;
                }
                else if (read[i] >= '0' && read[i] <= '9')
                {
                    num++;
                }
                else
                {
                    special++;
                }
            }

            Console.WriteLine($"Alphabet count in string is {alph}");
            Console.WriteLine($"Integer count in string is {num}");
            Console.WriteLine($"Special character count in string is {special}");
            #endregion

            Dictionary<char, int> dicCharCount = new Dictionary<char, int>();

            for (int i = 0; i < read?.Length; i++)
            {
                if (dicCharCount.ContainsKey(read[i]))
                {
                    dicCharCount[read[i]]++;
                }
                else
                    dicCharCount.Add(read[i], 1);
            }

            //var val = dicCharCount.Max();

            //Console.WriteLine(dicCharCount.Max().Value);

            /// Count of words in a string
            //Console.WriteLine(read.Split(' ').Length);

            //int counter = 0;
            //foreach (char a in read)
            //{
            //    counter++;
            //}
            //Console.WriteLine(counter);

            #region Palindrome
            string s4 = "raja";
            string s1 = string.Join("", s.Reverse().ToArray());
            if (read == s)
                Console.WriteLine("Palindrome");
            else Console.WriteLine("Non Palindrome");
            #endregion




            #endregion

            #region Tree
            BTree bTree = new BTree(5);
            //bTree.InsertNodeBST(1);
            //bTree.InsertNodeBST(7);

            //var b = bTree.SearchBST(bTree.rootNode, 5);


            bTree.printInOrder();
            //bTree.rootNode.left = new TreeNode(4);
            //bTree.rootNode.right = new TreeNode(6);
            //bTree.rootNode.left.left = new TreeNode(8);
            //bTree.printPostorder();
            //Console.WriteLine();
            //bTree.printPreOrder();
            //Console.WriteLine();
            //bTree.printInOrder();
            //Console.WriteLine(bTree.size(bTree.rootNode));
            //Console.ReadLine(); 
            #endregion

            #region Array

            #region Plus one in an array
            //Given a non-empty array of digits representing a non-negative integer, increment one to the integer.
            //Input: [1,2,3]
            //Output:[1,2,4]

            int[] PlusOne(int[] digits)
            {
                for (int i = digits.Length - 1; i >= 0; i--)
                {
                    if (digits[i] == 9)
                    {
                        digits[i] = 0;
                    }
                    else
                    {
                        digits[i] = digits[i] + 1;
                        return digits;
                    }
                }

                int[] arr = new int[digits.Length + 1];
                arr[0] = 1;
                return arr;
            }
        }
        #endregion

        #endregion

        #region Arithmetic

        #region Square Root
        //int sq = 0;
        //int x = 6;

        //    while (sq <= x / 2)
        //    {
        //        if (sq* sq == x)
        //        {
        //            Console.WriteLine(sq);
        //            break;
        //        }
        //        else if (sq* sq > x)
        //        {
        //            Console.WriteLine(sq - 1);
        //            break;
        //        }
        //    sq++;
            
            #endregion
            #endregion
        
    }
}
