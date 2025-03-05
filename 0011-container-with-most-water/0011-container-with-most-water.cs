public class Solution {
    public int MaxArea(int[] height) {
        int max = 0;
        int startPos = 0;
        int endPos = height.Length - 1;

        while(startPos < endPos)
        {          
            int currentArea = (endPos - startPos) * Math.Min(height[startPos], height[endPos]);
            max = Math.Max(max, currentArea);
            
            if(height[startPos] < height[endPos])
                startPos++;
            else
                endPos--;
        }

        return max;
    }
}