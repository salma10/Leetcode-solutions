public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        
        HashSet<int> nums1Hash = nums1.ToHashSet();
        HashSet<int> nums2Hash = nums2.ToHashSet();
        List<int> nums1Result = new List<int>();
        List<int> nums2Result = new List<int>();
        List<IList<int>> result = new List<IList<int>>();

        foreach(int num1 in nums1Hash)
        {
            if(!nums2Hash.Contains(num1))
               nums1Result.Add(num1); 
        }
        
        foreach(int num2 in nums2Hash)
        {
            if(!nums1Hash.Contains(num2))
               nums2Result.Add(num2); 
        }

        result.Add(nums1Result);
        result.Add(nums2Result);
        return result;
    }
}