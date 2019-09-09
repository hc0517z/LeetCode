using System.Linq;

namespace LeetCode._1_TwoSum
{
    public class TwoSum
    {
        public int[] Solution(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new[] {i, j};
                }
            }
            return new[] {0, 0};
        }
    }
}