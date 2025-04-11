public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int count = 0;
        for (int j = 0; j < nums.Length; j++)
        {
            if (count < 2 || nums[j] > nums[count-2])
                nums[count++] = nums[j];
        }
        return count;
    }
}