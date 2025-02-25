public class Solution {
    public int FindPoisonedDuration(int[] timeSeries, int duration) { 
        int total = 0;
        total += duration;

        for(int i = 1; i < timeSeries.Length; i++)
        {         
            int difference = timeSeries[i] - timeSeries[i - 1];
            if(difference >= duration)
                total += duration;
            else
                total += difference; 
        }
        return total;
    }
}