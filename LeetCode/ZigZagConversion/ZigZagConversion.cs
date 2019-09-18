using System.Collections.Generic;
using System.Linq;

namespace LeetCode.ZigZagConversion
{
    public enum Direction
    {
        Up,
        Down
    }
    
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1) return s;
            
            var dic = Enumerable.Range(0, numRows).ToDictionary(i => i, i => new List<char>());

            var row = -1;
            var direction = Direction.Down;
            
            foreach (char c in s)
            {
                if (direction == Direction.Down)
                {
                    row++;
                }
                else
                {
                    row--;
                }
                dic[row].Add(c);

                if (row == 0) direction = Direction.Down;
                if (row == numRows - 1) direction = Direction.Up;
            }

            var answer = string.Empty;
            foreach (var pair in dic)
            {
                answer += new string(pair.Value.ToArray());
            }
            return answer;
        }
    }
}