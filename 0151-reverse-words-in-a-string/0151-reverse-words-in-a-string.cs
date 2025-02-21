public class Solution {
    public string ReverseWords(string s) {
        string[] splittedString = s.Split(" ");
        StringBuilder result = new StringBuilder();
        int startPos = 0;
        int endPos = splittedString.Length - 1;

        for(int i = 0; i < splittedString.Length; i++)
        {
            if(string.IsNullOrEmpty(splittedString[i]))
                startPos++;
            else
                break;
        }

        for(int i = splittedString.Length - 1; i >= 0; i--)
        {
            if(string.IsNullOrEmpty(splittedString[i]))
                endPos--;
            else
                break;
        }

        for(int i = endPos; i >= startPos; i--)
        {
            if(!string.IsNullOrEmpty(splittedString[i]))
            {
                result.Append(splittedString[i]);
                if(i != startPos)
                    result.Append(" ");
            }
        }
             
        return result.ToString();
    }
}