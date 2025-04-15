public class Solution {
    public bool IsIsomorphic(string s, string t) { 
        Hashtable map = new Hashtable();
        for(int i = 0; i < s.Length; i++)
        {
            if(map.Contains(s[i]))
            {
                if((char)map[s[i]] != t[i])
                    return false;
            }             
            else if(map.ContainsValue(t[i]))
            {
                return false;
            }               
            else
                map.Add(s[i], t[i]);
        }
        return true;
    }
}