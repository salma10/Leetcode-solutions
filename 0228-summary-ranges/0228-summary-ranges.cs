public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        
        if(nums == null || nums.Length == 0)
            return new List<string>();
        
        List<string> result = new List<string>();
        int firstNumber = nums[0];
        int lastNumber = nums[0];
        
        for(int i = 1; i < nums.Length; i++)
        {
            if(lastNumber + 1 == nums[i])
                lastNumber = nums[i];
            else
            {
                AddResult(firstNumber, lastNumber, ref result);
                lastNumber = nums[i];
                firstNumber = nums[i];
            }
        }
        AddResult(firstNumber, lastNumber, ref result);
        return result;
    }

    private void AddResult(int firstNumber, int lastNumber, ref List<string> result)
    {
        if(firstNumber == lastNumber)
            result.Add(firstNumber.ToString());  
        else
            result.Add(firstNumber.ToString() + "->" + lastNumber.ToString());
    }
}