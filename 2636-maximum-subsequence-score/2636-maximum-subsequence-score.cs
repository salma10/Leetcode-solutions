public class Solution {
    public long MaxScore(int[] nums1, int[] nums2, int k) {
        int[][] numPair = new int[nums1.Length][];
        PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
        long sum = 0;
        long result = 0;
    
        for(int i = 0; i < nums1.Length; i++)
        {
            numPair[i] = new int[]{nums1[i], nums2[i]};
        }
        Array.Sort(numPair, (a,b) => b[1] - a[1]);

        for(int i = 0; i < k; i++)
        {
            sum += (long)numPair[i][0];
            queue.Enqueue(numPair[i][0], numPair[i][0]);
        }
        result = sum * numPair[k - 1][1];
        for(int i = k; i < nums1.Length; i++)
        {
            int last_small = queue.Dequeue();
            sum += (long)numPair[i][0] - last_small;
            queue.Enqueue(numPair[i][0], numPair[i][0]);
            result = Math.Max(result, sum * numPair[i][1]);
        }

        return result;
    }
}