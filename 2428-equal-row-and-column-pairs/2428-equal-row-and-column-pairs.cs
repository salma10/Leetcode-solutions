public class Solution {
    public int EqualPairs(int[][] grid) {
        Dictionary<string, int> rows = new Dictionary<string, int>();
        Dictionary<string, int> columns = new Dictionary<string, int>();
        int result = 0;

        for(int i = 0; i < grid.Length; i++)
        {
            string rowString = string.Empty;
            string colString = string.Empty;
            for(int j = 0; j < grid[0].Length; j++)
            {
                rowString += grid[i][j].ToString() + "#";
                colString += grid[j][i].ToString() + "#";
            }

            if(!rows.ContainsKey(rowString))
                rows[rowString] = 0;
            rows[rowString]++;

            if(!columns.ContainsKey(colString))
                columns[colString] = 0;
            columns[colString]++;
        }

        foreach(KeyValuePair<string, int> item in rows)
        {
            if(columns.ContainsKey(item.Key))
                result += item.Value * columns[item.Key];
        }

        return result;
    }
}