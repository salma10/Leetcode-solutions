public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int shift = 0;
        int val = nums[0];
        int currCount = 1;

        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] == val && currCount >= 2)
            {
                shift++;
            }
            else if(nums[i] == val)
            {
                currCount++;
            }
            else
            {
               val =  nums[i];
               currCount = 1;
            } 
            nums[i - shift] = nums[i];
        }
        return nums.Length - shift;
    }
}