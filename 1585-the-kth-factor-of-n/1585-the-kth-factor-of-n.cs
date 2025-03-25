public class Solution {
    PriorityQueue<int, int> heap = new PriorityQueue<int, int>(new DecreaseCompare<int>());
    public void heappushK(int x, int k) {
        heap.Enqueue(x, x);
        if (heap.Count > k) {
            heap.Dequeue();    
        }
    }
    public int KthFactor(int n, int k) {
        int sqrtN = (int) Math.Sqrt(n);
        for (int x = 1; x < sqrtN + 1; ++x) {
            if (n % x == 0) {
                heappushK(x, k);
                if (x != n / x) {
                    heappushK(n / x, k);    
                }    
            }    
        }  
        return k == heap.Count ? heap.Dequeue() : -1;
    }
    
    public class DecreaseCompare<T> : IComparer<T> where T : IComparable<T>
    {
        public int Compare(T x, T y)
        {
            return y.CompareTo(x);
        }
    }
}