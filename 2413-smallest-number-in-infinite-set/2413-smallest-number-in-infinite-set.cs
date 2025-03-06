public class SmallestInfiniteSet {
    SortedSet<int> queue;
    public SmallestInfiniteSet() {
        queue = new SortedSet<int>(Enumerable.Range(1, 1000));
    }
    
    public int PopSmallest() {
        int minElement = queue.Min();
        queue.Remove(minElement);
        return minElement;
    }
    
    public void AddBack(int num) {       
        queue.Add(num);
    }
}

/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */