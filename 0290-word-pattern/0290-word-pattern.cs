public class Solution {
    public bool WordPattern(string pattern, string s) {     
        string[] words = s.Split(' ');
        if(words.Length != pattern.Length)
            return false;
        
        Dictionary<char, string> patternHash = new Dictionary<char, string>();
        Dictionary<string, char> assigned = new Dictionary<string, char>();
        
        for(int i = 0; i < pattern.Length; i++)
        {
            if(patternHash.ContainsKey(pattern[i]) && patternHash[pattern[i]] != words[i])
                return false;
            else if(assigned.ContainsKey(words[i]) && assigned[words[i]] != pattern[i])
                return false;
            else
            {
                patternHash[pattern[i]] = words[i];
                assigned[words[i]] = pattern[i];
            }  
        }       
        return true;
    }
}