public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;
        s = s.ToLower();

        while(left <= right)
        {
            if(!char.IsLetterOrDigit(s[left]))
                left++;
            else if(!char.IsLetterOrDigit(s[right]))
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