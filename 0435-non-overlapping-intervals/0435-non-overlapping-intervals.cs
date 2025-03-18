public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[0] - b[0]);
        int result = 0;

        for(int i = 1; i < intervals.Length; i++)
        {
            int[] previous = intervals[i - 1];
            int[] current = intervals[i];
            // Console.WriteLine("current[0] " + current[0]);
            // Console.WriteLine("previous[1] " + previous[1]);
            if(current[0] < previous[1])
            {
                // Console.WriteLine("current[1] " + current[1]);
                if(current[1] > previous[1])
                    intervals[i] = previous;
                result++;
            }
            else if(current[0] == previous[0] && current[1] == previous[1])
                result++;
        } 

        return result;
    }
}