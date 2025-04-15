public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char, int> dataMap = new Dictionary<char, int>();
        for(int i = 0; i < magazine.Length; i++)
        {
            if(!dataMap.ContainsKey(magazine[i]))
                dataMap[magazine[i]] = 0;
            dataMap[magazine[i]]++;
        }
        for(int i = 0; i < ransomNote.Length; i++)
        {
            if(!dataMap.ContainsKey(ransomNote[i]))
                return false;
            dataMap[ransomNote[i]]--;
            if(dataMap[ransomNote[i]] == 0)
                dataMap.Remove(ransomNote[i]);
        }
        return true;
    }
}