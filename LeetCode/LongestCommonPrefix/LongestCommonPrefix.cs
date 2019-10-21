using System.Linq;

namespace LeetCode.LongestCommonPrefix
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var answer = string.Empty;
            var minLength = strs.Min(s => s.Length);
            var index = 0;
            
            while (index < minLength)
            {
                var idx = index;
                var indexChars = strs.Select(s => s[idx]).Distinct();
                var enumerable = indexChars.ToList();
                if (enumerable.Count == 1)
                {
                    answer = answer.PadRight(answer.Length + 1, enumerable.First());
                }
                else
                {
                    break;
                }
                
                index++;
            }
            
            return answer;
        }
    }
}