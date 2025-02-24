public class Solution {
    public int MaxVowels(string s, int k) {
        int maxNoOfVowel = 0;
        int currentNoOfVowels = 0;
        HashSet<char> vowels = new HashSet<char>{'a', 'e', 'i', 'o', 'u'};

        for(int i = 0; i < k; i++)
        {
            if(vowels.Contains(s[i]))
                currentNoOfVowels++;
        }
        maxNoOfVowel = Math.Max(maxNoOfVowel, currentNoOfVowels);

        for(int i = k; i < s.Length; i++)
        {
            if(vowels.Contains(s[i - k]))
                currentNoOfVowels--;

            if(vowels.Contains(s[i]))
                currentNoOfVowels++;

            maxNoOfVowel = Math.Max(maxNoOfVowel, currentNoOfVowels);
        }

        return maxNoOfVowel;
    }
}