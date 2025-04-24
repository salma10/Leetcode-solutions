public class Solution {
    public bool IsValid(string s) {
        Stack st = new Stack();
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '(' || s[i] == '{' || s[i] == '[')
                st.Push(s[i]);
            else if(s[i] == ')' && (st.Count == 0 || (char)st.Pop() != '('))
                return false;
            else if(s[i] == '}' && (st.Count == 0 || (char)st.Pop() != '{'))
                return false;
            else if(s[i] == ']' && (st.Count == 0 || (char)st.Pop() != '['))
                return false;             
        }
        
        if(st.Count == 0)
            return true;
        else
            return false;
        
    }
}