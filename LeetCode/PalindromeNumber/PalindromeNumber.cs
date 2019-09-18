namespace LeetCode.PalindromeNumber
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x == 0) return true;
            if (x < 0) return false;
            if (x % 10 == 0) return false;

            var revert = 0;
            while (x > revert)
            {
                revert = revert * 10 + x % 10;
                x /= 10;
            }

            return x == revert || x == revert / 10;
        }

//        public bool IsPalindrome(int x)
//        {
//            if (x == 0) return true;
//            if (x < 0) return false;
//            if (x % 10 == 0) return false;
//
//            var origin = x;
//            var revert = 0;
//            while (origin != 0)
//            {
//                var remain = origin % 10;
//                origin /= 10;
//                revert += remain;
//                if (origin != 0) revert *= 10;
//            }
//            return x == revert || x == revert / 10;
//        }
    }
}