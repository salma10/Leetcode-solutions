public class Solution {
    public string AddBinary(string a, string b) {
        int aLen = a.Length;
        int bLen = b.Length;
        
        if(aLen > bLen)
            b = b.PadLeft(aLen, '0');
        else
            a = a.PadLeft(bLen, '0');
        
        int rem = 0;
        string result = string.Empty;
        
        for(int i = a.Length - 1; i >= 0; i--)
        {
            int sum = (a[i] - 48) + (b[i] - 48) + rem;
            result = Convert.ToString(sum % 2) + result;
            rem = sum / 2;
        }
        
        if(rem != 0)
            result = Convert.ToString(rem) + result;
        return result;
    }
}