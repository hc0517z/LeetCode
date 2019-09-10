namespace LeetCode.LongestSubstring
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var start = 0;
            var tmp = string.Empty;
            var result = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                var index = tmp.IndexOf(s[i]);
                if (index != -1) start += index + 1;
                tmp = s.Substring(start, i - start + 1);
                if (result.Length < tmp.Length) result = tmp;
            }

            return result.Length;
        }
    }
}