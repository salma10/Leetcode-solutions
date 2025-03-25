public class Solution {
    public int KthFactor(int n, int k) {
        int number = 1;
        while(number <= n && k >= 0) 
        {
            if (n % number == 0) 
                k--;
            if(k == 0)
                return number;
            number++;
        }  
        return -1;
    }
}