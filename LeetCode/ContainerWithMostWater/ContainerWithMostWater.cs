using System;

namespace LeetCode.ContainerWithMostWater
{
    public class Solution {
        public int MaxArea(int[] height)
        {
            var maxArea = int.MinValue;

            for (int i = 0, j = height.Length - 1;  i < j;)
            {
                var calcArea = Math.Min(height[i], height[j]) * (j - i);
                maxArea = Math.Max(maxArea, calcArea);
                
                if (height[i] < height[j]) i++;
                else j--;
            }

            return maxArea;
        }
        
//        public int MaxArea(int[] height)
//        {
//            var maxArea = 0;
//
//            var leftPointIndex = 0;
//            var rightPointIndex = height.Length - 1;
//
//            while (leftPointIndex < rightPointIndex)
//            {
//                var calcArea = Math.Min(height[leftPointIndex], height[rightPointIndex]) * (rightPointIndex - leftPointIndex);
//                maxArea = Math.Max(maxArea, calcArea);
//                
//                if (height[leftPointIndex] < height[rightPointIndex])
//                {
//                    leftPointIndex++;
//                }
//                else
//                {
//                    rightPointIndex--;
//                }
//            }
//
//            return maxArea;
//        }
    }
}