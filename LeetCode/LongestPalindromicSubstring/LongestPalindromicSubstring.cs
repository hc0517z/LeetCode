using System;

namespace LeetCode.LongestPalindromicSubstring
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return string.Empty;
            var start = 0;
            var end = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var len1 = ExpandAroundCenter(s, i, i);
                var len2 = ExpandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }
            return s.Substring(start, end - start + 1);
        }

        private int ExpandAroundCenter(string s, int left, int right)
        {
            int l = left, r = right;
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                l--;
                r++;
            }
            return r - l - 1;
        }

//        public string LongestPalindrome(string s)
//        {
//            var answer = s == string.Empty ? s : s.First().ToString();
//            for (int i = 0; i < s.Length; i++)
//            {
//                for (int j = i; j < s.Length; j++)
//                {
//                    var start = Math.Min(i, j);
//                    var end = Math.Max(i, j);
//                    var originStr = s.Substring(start, end - start + 1);
//                    var compareStr = string.Concat(originStr.Reverse());
//                    if (originStr == compareStr)
//                    {
//                        if (answer.Length <= originStr.Length)
//                        {
//                            answer = originStr;
//                        }
//                    }
//                }
//            }
//            return answer;
//        }
    }
}