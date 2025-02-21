public class RecentCounter {
    Queue<int> requests;
    public RecentCounter() {
        requests = new Queue<int>();
    }
    
    public int Ping(int t) {
        requests.Enqueue(t);
        int range = t - 3000;
        while(requests.Peek() < range)
            requests.Dequeue();
        return requests.Count;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */