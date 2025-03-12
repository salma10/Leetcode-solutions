public class Solution {
    public long TotalCost(int[] costs, int k, int candidates) {
        PriorityQueue<int, int> firstQueue = new PriorityQueue<int, int>();
        PriorityQueue<int, int> secondQueue = new PriorityQueue<int, int>();
        int startPos = 0;
        int endPos = costs.Length - 1;
        long totalCost = 0;
        Console.WriteLine("Length " + costs.Length);
        int cadidateNo = candidates;

        while(cadidateNo > 0 && startPos < costs.Length)
        {
            firstQueue.Enqueue(costs[startPos], costs[startPos]);
            startPos++;
            cadidateNo--;
        }
        cadidateNo = candidates;
        while(cadidateNo > 0 && endPos >= startPos)
        {
            secondQueue.Enqueue(costs[endPos], costs[endPos]);
            endPos--;
            cadidateNo--;
        }
        while(k > 0)
        {
            if(secondQueue.Count == 0 || (firstQueue.Count > 0 && firstQueue.Peek() <= secondQueue.Peek()))
            {
                totalCost += (long)firstQueue.Dequeue();
                if(startPos <= endPos)
                {
                    firstQueue.Enqueue(costs[startPos], costs[startPos]);
                    startPos++;
                }
            }
            else if(secondQueue.Count > 0)
            {
                totalCost += (long)secondQueue.Dequeue();
                if(endPos >= startPos)
                {
                    secondQueue.Enqueue(costs[endPos], costs[endPos]);
                    endPos--;
                }
            }
            else
                break;
            k--;
        }
        return totalCost;
    }
}