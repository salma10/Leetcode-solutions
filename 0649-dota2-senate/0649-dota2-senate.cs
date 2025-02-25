public class Solution {
    public string PredictPartyVictory(string senate) {
        Queue<int> rPositions = new Queue<int>();
        Queue<int> dPositions = new Queue<int>();
        int len = senate.Length;

        for(int i = 0; i < len; i++)
        {
            if(senate[i] == 'R')
                rPositions.Enqueue(i);
            else
                dPositions.Enqueue(i);
        }

        while(rPositions.Count > 0 && dPositions.Count > 0)
        {
            int currentRPosition = rPositions.Dequeue();
            int currentDPosition = dPositions.Dequeue();

            if(currentRPosition < currentDPosition)
                rPositions.Enqueue(currentRPosition + len);
            else
                dPositions.Enqueue(currentDPosition + len);
        }

        return rPositions.Count == 0 ? "Dire" : "Radiant";
    }
}