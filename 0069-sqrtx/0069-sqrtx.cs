public class Solution {
    public int MySqrt(int x)
    {
        if(x == 0)
            return 0;
        
        if(x < 3)
            return 1;

        int left = 1, right = x;       
        
        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            
            if((long)mid * mid == (long)x)
                return mid; 
            else if((long)mid * mid < (long)x) 
                left = mid + 1; 
            else 
                right = mid - 1; 
        }
        return right;
    }
}