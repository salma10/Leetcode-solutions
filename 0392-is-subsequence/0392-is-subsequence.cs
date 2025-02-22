public class Solution {
    public bool IsSubsequence(string s, string t) {
        
        if (string.IsNullOrEmpty(s))
            return true;
        if (string.IsNullOrEmpty(t)) 
            return false; 
        
        int index = 0;
        
        for(int i = 0; i < t.Length; i++)
        {
            if(s[index] == t[i])
                index++;
            if(index == s.Length)
                return true;
        }
        
        return false;     
    }
}