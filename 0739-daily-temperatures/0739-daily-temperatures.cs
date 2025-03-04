public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] results = new int[temperatures.Length];
        Stack<int> data = new Stack<int>();

        for(int i = 0; i < temperatures.Length; i++)
        {
            while(data.Count > 0 && temperatures[data.Peek()] < temperatures[i])
            {
                results[data.Peek()] = i - data.Pop();
            }
            data.Push(i);
        } 
        return results;
    }
}