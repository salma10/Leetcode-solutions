public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        if((str1 + str2) != (str2 + str1))
            return "";
        int gcdValue = GCD(str1.Length, str2.Length);      
        return str2.Substring(0, gcdValue);
    }

    public int GCD(int len1, int len2)
    {
        if(len2 == 0)
            return len1;
        else
            return GCD(len2, len1 % len2);
    }
}