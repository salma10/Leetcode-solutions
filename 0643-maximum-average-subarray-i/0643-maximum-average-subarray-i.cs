public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double maxAvg = 0;
        int currentTotal = 0;

        for(int i = 0; i < k; i++)
        {
            currentTotal += nums[i];
        }
        maxAvg = (double) currentTotal / k;

        for(int i = k; i < nums.Length; i++)
        {
            currentTotal -= nums[i - k];
            currentTotal += nums[i];
            maxAvg = Math.Max(maxAvg, (double) currentTotal / k);
        }

        return maxAvg;
    }
}