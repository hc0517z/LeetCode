using System.Linq;

namespace LeetCode.StringToIntegerAtoi
{
    public class Solution
    {
        public int MyAtoi(string str)
        {
            long answer = 0;
            var trimStr = str.Trim();
            if (string.IsNullOrEmpty(trimStr)) return 0;
            
            var first = trimStr.First();
            if (!(char.IsDigit(first) || first == '+' || first == '-'))
            {
                return 0;
            }

            var isNegative = first == '-';
            foreach (char c in char.IsDigit(first) ? trimStr : trimStr.Skip(1))
            {
                if (char.IsDigit(c))
                {
                    answer = (long) (answer * 10 + char.GetNumericValue(c));
                    if (answer > int.MaxValue | answer < int.MinValue)
                    {
                        return isNegative ? int.MinValue : int.MaxValue;
                    }
                }
                else break;
            }

            return (int) (isNegative ? answer * -1 : answer);
        }
    }
}