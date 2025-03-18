public class Solution {
    public int FindMinArrowShots(int[][] points) {
        Array.Sort(points, (a, b) => { 
            return a[0].CompareTo(b[0]);
        });
        List<int[]> result = new List<int[]>();
        result.Add(points[0]);
        int resultPos = 0;

        for(int i = 1; i < points.Length; i++)
        {
            int[] current = points[i];
            if(result[resultPos][1] >= current[0])
            {
                if(result[resultPos][1] < current[1])
                    result[resultPos][0] = current[0];
                else
                    result[resultPos][1] = current[1];
            }
            else
            {
                result.Add(current);
                resultPos++;
            }
        } 

        return result.Count;
    }
}