namespace LeetCode.MedianOfTwoSortedArrays
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var mergeNums = new int[nums1.Length + nums2.Length];
            var mergeNumsIndex = 0;

            var num1Index = 0;
            var num2Index = 0;

            while (mergeNumsIndex < mergeNums.Length)
            {
                int addNum;

                var num1 = num1Index < nums1.Length ? nums1[num1Index] : int.MaxValue;
                var num2 = num2Index < nums2.Length ? nums2[num2Index] : int.MaxValue;
                
                if (num1 < num2)
                {
                    addNum = num1;
                    num1Index++;
                }
                else if (num1 > num2)
                {
                    addNum = num2;
                    num2Index++;
                }
                else
                {
                    if (num1 == int.MaxValue) break;
                    
                    addNum = num1;
                    num1Index++;
                    num2Index++;
                    
                    mergeNums[mergeNumsIndex] = addNum;
                    mergeNumsIndex++;
                }

                mergeNums[mergeNumsIndex] = addNum;
                mergeNumsIndex++;
            }

            var halfIndex = mergeNums.Length / 2;
            if (mergeNums.Length % 2 == 1)
            {
                return mergeNums[halfIndex];
            }

            var prevHalfIndex = halfIndex - 1;
            var nextHalfIndex = halfIndex;
            return (mergeNums[prevHalfIndex] + mergeNums[nextHalfIndex]) / 2.0;
        }
    }
}