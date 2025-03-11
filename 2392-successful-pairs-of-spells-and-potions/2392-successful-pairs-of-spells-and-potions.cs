public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        Array.Sort(potions);
        int len = spells.Length;
        int[] result = new int[len];

        for(int i = 0; i < len; i++)
        {
            result[i] = Search(potions, success, spells[i]);      
        }
        return result;
    }
    private int Search(int[] potions, long success, int spell)
    {
        int mid;
        int start = 0, end = potions.Length - 1;
        int resultIndex = potions.Length;

        while(start <= end)
        {
            mid = start + (end - start) / 2;
            long currentSuccess = ((long)potions[mid] * spell); 
            if(currentSuccess >= success)
            {
                resultIndex = mid;
                end = mid - 1;
            }             
            else
                start = mid + 1;  
        }
        return potions.Length - resultIndex;
    }
}