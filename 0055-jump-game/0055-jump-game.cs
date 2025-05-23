public class Solution {
    public bool CanJump(int[] nums) {
      if(nums.Length <= 1)
          return true;
      int count = 0;
      int length = nums.Length;
      int sum = 0; 
      while(count < length - 1)
      {
          sum = Math.Max(sum, count + nums[count]);          
          if(sum >= length - 1)
              return true;
          if(nums[count] == 0 && sum <= count)
              return false;
          count++;
      }
      return false;
    }
}