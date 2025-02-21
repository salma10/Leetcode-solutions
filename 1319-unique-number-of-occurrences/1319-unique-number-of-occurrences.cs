public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> arrUniqueValueCount = new Dictionary<int, int>();
        HashSet<int> arrUniqueValues = new HashSet<int>();

        for(int i = 0; i < arr.Length; i++)
        {
            if(arrUniqueValueCount.ContainsKey(arr[i]))
                arrUniqueValueCount[arr[i]]++;
            else
                arrUniqueValueCount[arr[i]] = 0;
        }

        foreach(KeyValuePair<int, int> arrUniqueValue in arrUniqueValueCount)
        {
            if(arrUniqueValues.Contains(arrUniqueValue.Value))
                return false;
            arrUniqueValues.Add(arrUniqueValue.Value);
        }
        return true;
    }
}