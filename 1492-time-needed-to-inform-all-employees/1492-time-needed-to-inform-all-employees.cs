public class Solution {
    public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime) {
        Dictionary<int, List<int>> tree = new Dictionary<int, List<int>>();
        tree[headID] = new List<int>{};
        int result = 0;

        for(int i = 0; i < manager.Length; i++)
        {
            if(!tree.ContainsKey(manager[i]))
                tree[manager[i]] = new List<int>();
            tree[manager[i]].Add(i);
        }

        Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
        queue.Enqueue(new Tuple<int, int> (headID, informTime[headID]));

        while(queue.Count > 0)
        {
            Tuple<int, int> node = queue.Dequeue();
            result = Math.Max(result, node.Item2);
            if (tree.ContainsKey(node.Item1))
            {
                foreach(int i in tree[node.Item1])
                {
                    queue.Enqueue(new Tuple<int, int> (i, node.Item2 + informTime[i]));
                }
            }
        }
        return result;
    }
}