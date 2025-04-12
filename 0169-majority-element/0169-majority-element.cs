public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> numsCount = new Dictionary<int, int>();
        int majorityNumber = nums.Length / 2;

        for(int i = 0; i < nums.Length; i++)
        {
            if(!numsCount.ContainsKey(nums[i]))
                numsCount[nums[i]] = 0;
            numsCount[nums[i]]++;
            if(numsCount[nums[i]] > majorityNumber)
                return nums[i];
        }

        foreach(KeyValuePair<int, int> item in numsCount)
        {
            if(item.Value > majorityNumber)
                return item.Key;
        }
        return -1;
    }
}