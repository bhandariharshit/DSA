using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;

namespace DSA.Strings
{
    public static class String
    {
        /// <summary>
        /// Write a function to find the longest common prefix string amongst an array of strings.
        /// If there is no common prefix, return an empty string "".
        /// Input: ["flower","flow","flight"] Output: "fl"
        /// </summary>
        /// <param name="strs">The STRS.</param>
        /// <returns></returns>
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (string.IsNullOrEmpty(prefix))
                        return "";
                }
            }

            return prefix;
        }

        public static bool IsPalindrome(string s)
        {
            s = Regex.Replace(s, "[^a-zA-Z0-9_]+", " ").ToLower().Replace(" ", "");
            return IsValidPalindorme(s, 0, s.Length - 1);
        }

        public static bool IsValidPalindorme(string s, int start, int end)
        {
            if (start == end)
                return true;

            if (start > end)
                return true;

            if (s[start] != s[end])
                return false;

            return IsValidPalindorme(s, start + 1, end - 1);
        }

        public static string ConvertToBinary(int n)
        {
            StringBuilder s = new StringBuilder();

            while (n != 0)
            {
                s.Insert(0, n % 2);
                n = n / 2;
            }

            return s.ToString();
        }

        // for
        // geefksforgeeks

        public static bool ValidSubstring(string a, string b)
        {
            int counter = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == a[counter])
                    counter++;
                else
                    counter = 0;

                if (counter == a.Length)
                    return true;
            }

            return false;
        }

        // for
        // geeksforgeeks

        /// <summary>
        /// Check if A is a substring of B using brute force.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static bool ValidSubstringBruteForce(string A, string B)
        {
            if (A.Length > B.Length)
                return false;

            for (int i = 0; i <= B.Length - A.Length; i++)
            {
                int j = 0;
                for (j = 0; j < A.Length; j++)
                {
                    if (A[j] != B[i + j])
                    {
                        break;
                    }
                }

                if (j == A.Length)
                    return true;
            }

            return false;
        }

        // This is an interview question
        // "SPACE"

        //This is an interview question0000000000000000

        //THISSPACEisSPACEanSPACEinterviewSPACEquestion
        public static string ReplaceCharInString(char[] word, char replaceChar, string replaceString)
        {
            if (word is null || word.Length.Equals(0) || string.IsNullOrEmpty(replaceString))
            {
                return new string(word);
            }

            int count = 0;

            int lastIndex = word.Length - 1;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == replaceChar)
                {
                    count++;
                }
            }

            int newLength = word.Length + ((replaceString.Length - 1) * count);

            System.Array.Resize<char>(ref word, newLength);

            for (int i = newLength - 1; i >= 0; i--)
            {
                if (word[lastIndex] != replaceChar)
                {
                    word[i] = word[lastIndex];
                    lastIndex--;
                }
                else
                {
                    for (int j = replaceString.Length - 1; j >= 0; j--)
                    {
                        word[i] = replaceString[j];
                        i--;
                    }
                    i++;
                    lastIndex--;
                }
            }

            return new string(word);
        }
    }
}
