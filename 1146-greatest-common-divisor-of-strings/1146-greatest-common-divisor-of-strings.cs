public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        int l1 = str1.Length, l2 = str2.Length;
        
        if(l2 > l1)
            (str1, str2) = (str2, str1);
        
        for(int i = str2.Length; i > 0; i--)
        {
            string max = str2.Substring(0, i);
            string t1 = str1.Replace(max, "");
            string t2 = str2.Replace(max, "");
            if(string.IsNullOrEmpty(t1) && string.IsNullOrEmpty(t2))
                return max;
        }
        
        return string.Empty;
    }
}