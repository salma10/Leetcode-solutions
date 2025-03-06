public class Solution {
    public int FindKthLargest(int[] nums, int k) {            
        PriorityQueue<int, int> queue = new PriorityQueue<int, int>(new DescendingComparer<int>());
        
        for(int index = 0; index < nums.Length; index++)
        {
            queue.Enqueue(nums[index], nums[index]);
        }

        while(k > 1)
        {
            queue.Dequeue();
            k--;
        }
        return queue.Dequeue();
    }
    
    public class DescendingComparer<T> : IComparer<T> where T : IComparable<T>
    {
        public int Compare(T x, T y)
        {
            return y.CompareTo(x);
        }
    }
}
