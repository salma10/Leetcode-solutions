public class Solution {
    public string ReverseWords(string s) {
        s = s.Trim();
        string[] splittedString = s.Split(" ");
        StringBuilder result = new StringBuilder();

        for(int i = splittedString.Length - 1; i >= 0; i--)
        {
            if(!string.IsNullOrEmpty(splittedString[i]))
            {
                result.Append(splittedString[i]);
                if(i != 0)
                    result.Append(" ");
            }
        }
             
        return result.ToString();
    }
}