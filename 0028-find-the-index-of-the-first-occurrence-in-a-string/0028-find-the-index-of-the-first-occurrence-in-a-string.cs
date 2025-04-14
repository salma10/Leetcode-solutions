public class Solution {
    public int StrStr(string haystack, string needle) {
        int firstPos = -1;
        for(int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            if(haystack[i] == needle[0])
                firstPos = MatchWords(haystack, needle, i);
            if(firstPos > -1)
                return firstPos;
        }
        return firstPos;
    }

    private int MatchWords(string haystack, string needle, int pos)
    {
        int j = 0;
        for(int i = pos; i < pos + needle.Length; i++)
        {
            if(haystack[i] != needle[j])
                return -1;
            j++;
        }
        return pos;
    }
}