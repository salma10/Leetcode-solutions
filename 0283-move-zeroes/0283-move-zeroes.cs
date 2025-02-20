public class Solution {
    public void MoveZeroes(int[] nums) {
        int positionOfZero = -1;
        int currentPos = 0;
        int posOfNonZeroNumber = -1;

        while(currentPos < nums.Length)
        {
            while(positionOfZero == -1 && currentPos < nums.Length)
            {
                if(nums[currentPos] == 0)
                    positionOfZero = currentPos;
                currentPos++;                                
            }

            posOfNonZeroNumber = currentPos;
            
            while(positionOfZero != -1 && positionOfZero != nums.Length - 1 && posOfNonZeroNumber < nums.Length)
            {
                if(nums[posOfNonZeroNumber] != 0)
                {
                    nums[positionOfZero] = nums[posOfNonZeroNumber];
                    nums[posOfNonZeroNumber] = 0;
                    currentPos = ++positionOfZero;
                    positionOfZero = -1;
                    posOfNonZeroNumber = -1;
                }
                else                 
                    posOfNonZeroNumber++;
            }
            if(posOfNonZeroNumber>= nums.Length)
                break;
        }
    }
}