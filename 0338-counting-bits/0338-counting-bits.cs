public class Solution {
    public int[] CountBits(int num) {    
        int[] result = new int[num + 1];
        
        for (int i = 1; i <= num; i++) 
            result[i] = result[i >> 1] + (i & 1); 
        return result;
    }
}