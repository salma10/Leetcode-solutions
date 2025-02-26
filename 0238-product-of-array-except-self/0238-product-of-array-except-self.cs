public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] answer = new int[nums.Length];
        answer[0] = 1;
        int current = 1;

        for(int i = 1; i < nums.Length; i++)
        {
            answer[i] = current * nums[i - 1];
            current = answer[i];
        }

        current = 1;

        for(int i = nums.Length - 2; i >= 0; i--)
        {
            current = current * nums[i + 1];
            answer[i] = answer[i] * current;
        }

        return answer;
    }
}