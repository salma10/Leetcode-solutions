public class Solution {
    public int FindKthLargest(int[] nums, int k) {            
        PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
        
        for(int index = 0; index < nums.Length; index++)
        {
            if(queue.Count < k)
                queue.Enqueue(nums[index], nums[index]);
            else if(queue.Peek() < nums[index])
            {
                queue.Dequeue();
                queue.Enqueue(nums[index], nums[index]);
            }
        }
        return queue.Peek();
    }
}
