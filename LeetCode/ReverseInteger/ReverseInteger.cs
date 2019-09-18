using System.Linq;

namespace LeetCode.ReverseInteger
{
    public class Solution 
    {
        public int Reverse(int x)
        {
            var isNegative = x < 0;
            var reverseString = new string(x.ToString().Where(char.IsDigit).Reverse().ToArray());
            int reverseInteger;
            int.TryParse(reverseString, out reverseInteger);
            return isNegative ? reverseInteger * -1 : reverseInteger;
        }        
        
//        public int Reverse(int x)
//        {
//            long result = 0;
//            while (x != 0)
//            {
//                var remain = x % 10;
//                x /= 10;
//                result = result * 10 + remain;
//            }
//
//            if (result > int.MaxValue |
//                result < int.MinValue)
//                return 0;
//            
//            return (int)result;
//        }
    }
}