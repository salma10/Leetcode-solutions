public class Solution {
    public bool CloseStrings(string word1, string word2) {
        if (word1.Length != word2.Length) return false; 
        
        var wordOneCharDict = new Dictionary<char, int>();
        var WordTwoCharDict = new Dictionary<char, int>();
        var wordOneFrequencyCount = new Dictionary<int, int>();
        var wordTwoFrequencyCount = new Dictionary<int, int>();

        foreach (var i in word1)
        {
            if (!wordOneCharDict.ContainsKey(i)) wordOneCharDict.Add(i, 0);
            wordOneCharDict[i]++;
        }
        foreach (var i in word2)
        {
            if (!WordTwoCharDict.ContainsKey(i)) WordTwoCharDict.Add(i, 0);
            WordTwoCharDict[i]++;
        }
        if (wordOneCharDict.Count != WordTwoCharDict.Count) return false;
            

        foreach (var i in wordOneCharDict)
        {
            if (!WordTwoCharDict.ContainsKey(i.Key))  return false; 
            if (!wordOneFrequencyCount.ContainsKey(i.Value)) wordOneFrequencyCount.Add(i.Value, 0);
			wordOneFrequencyCount[i.Value]++;
        }
        foreach (var i in WordTwoCharDict)
        {
            if (!wordTwoFrequencyCount.ContainsKey(i.Value)) wordTwoFrequencyCount.Add(i.Value, 0);
            wordTwoFrequencyCount[i.Value]++;
        }
        foreach (var i in wordOneFrequencyCount)
        {
            if (!wordTwoFrequencyCount.ContainsKey(i.Key) || wordTwoFrequencyCount.ContainsKey(i.Key) && wordTwoFrequencyCount[i.Key]!=i.Value)return false; 
        }
        return true;
    }
}