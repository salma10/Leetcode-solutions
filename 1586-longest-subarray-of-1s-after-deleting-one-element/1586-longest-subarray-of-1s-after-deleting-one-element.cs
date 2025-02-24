public class Solution {
    public int LongestSubarray(int[] nums) {
        int maxLen = 0;
        int startPos = 0;
        int zeroPosition = -1;
        
        for(int index = 0; index < nums.Length; index++)
        {
            if(nums[index] == 0 && zeroPosition != -1)
            {
                maxLen = Math.Max(maxLen, index - startPos - 1);
                startPos = zeroPosition + 1;
                zeroPosition = index;
            }
            if(nums[index] == 0)
            {
                zeroPosition = index;
            }
        }
        
        return zeroPosition == -1 ? nums.Length - 1 : Math.Max(maxLen, nums.Length - startPos - 1);
    }
}