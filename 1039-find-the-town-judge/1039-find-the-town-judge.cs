public class Solution {
    public int FindJudge(int N, int[][] trust) {      
        if(trust.Length == 0 && N == 1)
            return N;      
        if(trust.Length < N - 1)
            return -1;
        
        Dictionary<int,int> trustCount = new Dictionary<int,int>();
        
        for(int i = 0; i < trust.Length; i++)
        {
            if(trustCount.ContainsKey(trust[i][0]))
                trustCount[trust[i][0]]--;
            else
                trustCount[trust[i][0]] = -1; 
            
            if(trustCount.ContainsKey(trust[i][1]))
                trustCount[trust[i][1]]++;
            else
                trustCount[trust[i][1]] = 1; 
        }
        
        foreach(var item in trustCount)
        {
            if(item.Value == N - 1)
                return item.Key;
        }
        return -1;
    }
}