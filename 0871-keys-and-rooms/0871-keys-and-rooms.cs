public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        HashSet<int> visited = new HashSet<int>();     
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(0);
        visited.Add(0);    

        while(queue.Count > 0)
        {
            int i = queue.Dequeue();           
            IList<int> curr = rooms[i];
            for(int j = 0; j < curr.Count; j++)
            {
                if(!visited.Contains(curr[j]))
                {
                   queue.Enqueue(curr[j]);
                   visited.Add(curr[j]);
                }
            }
        }
        return visited.Count == rooms.Count;
    }
}