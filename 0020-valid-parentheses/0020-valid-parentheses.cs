public class Solution {
    public bool IsValid(string s) {
        Stack st = new Stack();
        Dictionary<char, char> matchingBrackets = new Dictionary<char, char> {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };
        for(int i = 0; i < s.Length; i++)
        {
            if(matchingBrackets.ContainsKey(s[i]))
                st.Push(matchingBrackets[s[i]]);
            else if((st.Count == 0 || (char)st.Pop() != s[i]))
                return false;       
        }
        return st.Count == 0;
    }
}