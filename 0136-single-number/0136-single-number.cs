public class Solution {
    public int SingleNumber(int[] nums) {
        if(nums.Length == 0)
            return 0;
        for(int i = 1; i < nums.Length; i++)
        {
            nums[0] = nums[0] ^ nums[i];
        }
        return nums[0];
    }
}