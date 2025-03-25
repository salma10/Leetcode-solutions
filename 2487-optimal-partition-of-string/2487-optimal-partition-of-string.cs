public class Solution {
    public int PartitionString(string s) {
        int bits = 0;
        int noOfPartitions = 1;

        for(int i = 0; i < s.Length; i++)
        {
            int bit = 1 << (s[i] - 'a');
            if((bits & bit) == 0)
                bits |= bit;
            else
            {
               bits = bit; 
               noOfPartitions++;
            }           
        }
        return noOfPartitions;
    }
}