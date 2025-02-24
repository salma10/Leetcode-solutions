public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int maxLen = 0;
        int startPos = 0;
        Queue<int> zeroPositions = new Queue<int>();
        
        for(int index = 0; index < nums.Length; index++)
        {
            if(nums[index] == 0)
                zeroPositions.Enqueue(index);
            if(zeroPositions.Count > k)
            {
                maxLen = Math.Max(maxLen, index - startPos);
                startPos = zeroPositions.Dequeue() + 1;
            }
        }
        maxLen = Math.Max(maxLen, nums.Length - startPos);
        return maxLen;
    }
}