public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int shift = 0;
        int val = nums[0];
        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] == val)
            {
                shift++;
            }
            else
            {
               val =  nums[i];
            }             
            nums[i - shift] = nums[i];
        }
        return nums.Length - shift;
    }
}