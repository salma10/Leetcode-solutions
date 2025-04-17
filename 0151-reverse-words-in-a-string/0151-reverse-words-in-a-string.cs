public class Solution {
    public string ReverseWords(string s) {
        StringBuilder result = new StringBuilder();
        StringBuilder currentWord = new StringBuilder();

        for(int i = s.Length - 1; i >= 0; i--)
        {
            if(s[i] == ' ')
            {
                if(currentWord.Length > 0)
                {
                    currentWord = Reverse(currentWord);
                    result.Append(currentWord.ToString());
                    result.Append(" ");
                    currentWord.Clear();
                }
            }
            else
               currentWord.Append(s[i].ToString());
        }
        if(currentWord.Length > 0)
        {
            currentWord = Reverse(currentWord);
            result.Append(currentWord.ToString());
            currentWord.Clear();
        }
             
        return result.ToString().Trim();
    }
    private StringBuilder Reverse(StringBuilder currentWord)
    {
        for (int k = 0, j = currentWord.Length - 1; k < j; k++, j--)
        {
            char temp = currentWord[k];
            currentWord[k] = currentWord[j];
            currentWord[j] = temp;
        }
        return currentWord;
    }
}