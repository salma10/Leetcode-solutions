public class Solution {
    public int FindPeakElement(int[] nums) {
        if(nums == null || nums.Length == 0)
            return -1;

        int mid;
        int start = 0;
        int end = nums.Length - 1;

        while(start < end)
        {
            mid = start + (end - start) / 2;
            if(mid < end && nums[mid] > nums[mid + 1])
                end = mid; 
            else 
                start = mid + 1; 
        }
        return start;
    }
}