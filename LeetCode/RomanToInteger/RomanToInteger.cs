using System.Collections.Generic;

namespace LeetCode.RomanToInteger
{
    public class Solution
    {
        private readonly Dictionary<char, int> charToInt = new Dictionary<char, int>
                                                     {
                                                         {'I', 1},
                                                         {'V', 5},
                                                         {'X', 10},
                                                         {'L', 50},
                                                         {'C', 100},
                                                         {'D', 500},
                                                         {'M', 1000}
                                                     };
        
//        public int RomanToInt(string s)
//        {
//            var answer = 0;
//            var currentIndex = 0;
//            
//            while (currentIndex < s.Length)
//            {
//                var currentChar = s[currentIndex];
//                if (currentIndex < s.Length - 1)
//                {
//                    var nextChar = s[currentIndex + 1];
//                    if (charToInt[currentChar] < charToInt[nextChar])
//                    {
//                        answer += charToInt[nextChar] - charToInt[currentChar];
//                        currentIndex += 2;
//                        continue;
//                    }
//                }
//                answer += charToInt[currentChar];
//                currentIndex += 1;
//            }
//            
//            return answer;
//        }
        
        public int RomanToInt(string s)
        {
            var answer = 0;
            var preValue = 0;
            var curIndex = s.Length - 1;
            
            while (curIndex >= 0)
            {
                var curChar = s[curIndex];
                var curValue = charToInt[curChar];

                if (curValue >= preValue)
                {
                    answer += curValue;
                }
                else
                {
                    answer -= curValue;
                }

                preValue = curValue;
                curIndex--;
            }
            
            return answer;
        }
    }
}