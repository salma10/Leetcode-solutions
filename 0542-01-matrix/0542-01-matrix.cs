public class Solution {
    public int[][] UpdateMatrix(int[][] mat) {
        
        int len = mat.Length;
        int col = mat[0].Length;
        int[][] result = new int[len][];
        Queue<int[]> ZeroPos = new Queue<int[]>();
        
        for(int i = 0; i < len; i++)
            result[i] = Enumerable.Repeat(Int32.MaxValue, mat[0].Length).ToArray();
        
        for(int i = 0; i < len; i++)
        {
            for(int j = 0; j < col; j++)
            {
                if(mat[i][j] == 0)
                {
                   ZeroPos.Enqueue(new int[] {i, j}); 
                   result[i][j] = 0;
                }
            }
        }
        
        int[] dRow = new int[] { 0, 0, 1, -1 },
              dCol = new int[] { 1, -1, 0, 0 };
        
        while(ZeroPos.Count > 0)
        {
            int[] cur = ZeroPos.Dequeue();
            for (int k = 0; k < 4; k++)
            {
                if (cur[0] + dRow[k] > -1 && cur[0] + dRow[k] < result.Length && cur[1] + dCol[k] > -1 && cur[1] + dCol[k] < result[0].Length && result[cur[0] + dRow[k]][cur[1] + dCol[k]] > result[cur[0]][cur[1]] + 1)
                {
                    result[cur[0] + dRow[k]][cur[1] + dCol[k]] = result[cur[0]][cur[1]] + 1;
                    ZeroPos.Enqueue(new int[] { cur[0] + dRow[k], cur[1] + dCol[k] });
                }
            }
        }
        return result;
    }
}