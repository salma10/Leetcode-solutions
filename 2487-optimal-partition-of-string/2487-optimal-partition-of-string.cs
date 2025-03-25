public class Solution {
    public int PartitionString(string s) {
        HashSet<char> uniqueChar = new HashSet<char>();
        int noOfPartitions = 0;

        for(int i = 0; i < s.Length; i++)
        {
            if(uniqueChar.Contains(s[i]))
            {
                uniqueChar = new HashSet<char>();
                noOfPartitions++;
            }
            uniqueChar.Add(s[i]);
        }
        return noOfPartitions + 1;
    }
}