public class Solution {
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
        List<IList<int>> result = new List<IList<int>>();
        DFS(graph, 0, new List<int>{0}, result);
        return result;
    }
    
    private void DFS(int[][] graph, int start, IList<int> bucket, IList<IList<int>> result) {
        if (start == graph.Length - 1) {
            result.Add(new List<int>(bucket));
            return;
        }
        
        foreach(var j in graph[start]) {
            bucket.Add(j);
            DFS(graph, j, bucket, result);
            bucket.RemoveAt(bucket.Count - 1); 
        }
    }
}