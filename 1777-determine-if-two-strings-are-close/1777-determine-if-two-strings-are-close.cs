public class Solution {
    public bool CloseStrings(string word1, string word2) {
        
        if(word1.Length != word2.Length)
            return false;
            
        Dictionary<char, int> word1Count = new Dictionary<char, int>();
        Dictionary<char, int> word2Count = new Dictionary<char, int>();

        foreach(char c in word1)
        {
            if(!word1Count.ContainsKey(c))
                word1Count[c] = 0;
            word1Count[c]++;
        }

        foreach(char c in word2)
        {
            if(!word2Count.ContainsKey(c))
                word2Count[c] = 0;
            word2Count[c]++;
        }

        if(word1Count.Count != word2Count.Count)
            return false;
        
        Dictionary<int, int> word1Freq = new Dictionary<int, int>();
        Dictionary<int, int> word2Freq = new Dictionary<int, int>();

        foreach (KeyValuePair<char, int> i in word1Count)
        {
            if (!word2Count.ContainsKey(i.Key))  
                return false; 
            if (!word1Freq.ContainsKey(i.Value)) 
                word1Freq[i.Value] = 0;
			word1Freq[i.Value]++;
        }

        foreach(int freq in word2Count.Values)
        {
            if(!word2Freq.ContainsKey(freq))
                word2Freq[freq] = 0;
            word2Freq[freq]++;              
        }

        foreach (KeyValuePair<int, int> i in word1Freq)
        {
            if (!word2Freq.ContainsKey(i.Key) || word2Freq.ContainsKey(i.Key) && word2Freq[i.Key] != i.Value)
                return false; 
        }

        return true;
    }
}