public class Solution {
    public int LargestAltitude(int[] gain) {

        int highestAltitude = 0;
        int currentAltitude = 0;

        for(int i = 0; i < gain.Length; i++)
        {
            currentAltitude = gain[i] + currentAltitude;
            highestAltitude= Math.Max(highestAltitude, currentAltitude);
        }

        return highestAltitude;
    }
}