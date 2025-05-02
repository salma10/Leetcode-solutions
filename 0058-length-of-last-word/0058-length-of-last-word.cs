public class Solution {
    public int LengthOfLastWord(string s) {   
        s = s.Trim();    
        int firstPos = 0;

        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == ' ')
                firstPos = i + 1;
        }
        return s.Length - firstPos;
    }
}