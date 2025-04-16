public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;
        s = s.ToLower();
        HashSet<char> alphanumeric  = new HashSet<char>{
            'a','b','c','d','e','f','g','h','i','j',
            'k','l','m','n','o','p','q','r','s','t',
            'u','v','w','x','y','z', '0','1','2','3',
            '4','5','6','7','8','9'
        };
        while(left <= right)
        {
            if(!alphanumeric.Contains(s[left]))
                left++;
            else if(!alphanumeric.Contains(s[right]))
                right--;
            else if(s[left] != s[right])
                return false;
            else
            {
                left++;
                right--;
            }
        }
        return true;
    }
}