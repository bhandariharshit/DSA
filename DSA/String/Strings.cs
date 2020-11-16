using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DSA.Strings
{
    public static class Strings
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

                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (string.IsNullOrEmpty(prefix)) 
                        return "";
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

            while(n != 0)
            {
                s.Insert(0, n % 2);
                n = n / 2;
            }

            return s.ToString();
        }
    }
}
