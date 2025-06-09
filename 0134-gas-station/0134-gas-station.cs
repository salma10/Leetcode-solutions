public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int remainingGasUnit = 0;
        int currGasUnit = 0;
        int start = 0;
        for(int i = 0; i < gas.Length; i++)
        {
            currGasUnit += gas[i] - cost[i];
            if(currGasUnit < 0)
            {
                start = (i + 1) % gas.Length;
                currGasUnit = 0;
            }
            remainingGasUnit += gas[i] - cost[i];
        }
        return remainingGasUnit >= 0 ? start : -1;
    }
}