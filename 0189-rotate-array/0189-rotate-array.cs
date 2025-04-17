public class Solution {
    public void Rotate(int[] nums, int k) {
        if(k < 1)
            return;
        int len = nums.Length - 1;
        k %= (len + 1);
        RotateToSpecificIndex(nums, 0, len);
        RotateToSpecificIndex(nums, 0, k - 1);
        RotateToSpecificIndex(nums, k, len);
    }
    
    private void RotateToSpecificIndex(int[] nums, int startIndex, int endIndex)
    {
        while(startIndex < endIndex)
        {
            int temp = nums[startIndex];
            nums[startIndex] = nums[endIndex];
            nums[endIndex] = temp;
            startIndex++;
            endIndex--;
        }
    }
}