public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int len = nums.Length;      
        int currentSum = 0, left = 0;
        
        for(int i = 0; i < nums.Length; i++)
        {
            currentSum += nums[i];
            while(currentSum >= target && currentSum - nums[left] >= target)
                currentSum -= nums[left++];
            if(currentSum >= target)
                len = len > i - left + 1 ? i - left + 1 : len;
        }
        if(len == nums.Length && currentSum < target)
            return 0;
        return len;
    }
}