public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        List<bool> result = new List<bool>();
        int maxCandies = 0;

        for(int i = 0; i < candies.Length; i++)
        {
            maxCandies = Math.Max(maxCandies, candies[i]);
        }
        for(int i = 0; i < candies.Length; i++)
        {
            if(candies[i] + extraCandies >= maxCandies)
                result.Add(true);
            else
                result.Add(false);
        }
        return result;
    }
}