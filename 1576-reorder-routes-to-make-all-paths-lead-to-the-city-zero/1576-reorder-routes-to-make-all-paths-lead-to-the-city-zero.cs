public class Solution {
    public int MinReorder(int n, int[][] connections) {
        List<List<int>> graph = new List<List<int>>();

        for(int i = 0; i < n; i++)
            graph.Add(new List<int>());
 
        HashSet<(int, int)> edge = new HashSet<(int, int)>();
        HashSet<int> visited = new HashSet<int>();
        int count = 0;

        for(int i = 0; i < connections.Length; i++)
        {
            graph[connections[i][0]].Add(connections[i][1]);
            graph[connections[i][1]].Add(connections[i][0]);
            edge.Add((connections[i][0], connections[i][1]));
        }
        DFS(graph, edge, visited, 0, ref count);
        return count;
    }
    private void DFS(List<List<int>> graph, HashSet<(int, int)> edge, HashSet<int> visited, int currentCity, ref int count)
    {
        visited.Add(currentCity);
        foreach(int nextCity in graph[currentCity])
        {
            if(!visited.Contains(nextCity))
            {
                if(edge.Contains((currentCity, nextCity)))
                    count++;
                DFS(graph, edge, visited, nextCity, ref count);
            }
        }
    }
}