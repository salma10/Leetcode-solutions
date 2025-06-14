public class Solution {
    public int Jump(int[] nums) {
        int step = 0;
        int s = 0;
        int max = 0;
        for(int i=0; i < nums.Length-1; i++) 
        {
            max = Math.Max(max, i+nums[i]);
            if( i == s ) 
            {
                step++;
                s = max;
            } 
        }
        return step;
    }
}