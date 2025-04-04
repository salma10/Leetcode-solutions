public class Solution {
    public int[][] UpdateMatrix(int[][] mat) {
        
        int len = mat.Length;
        int col = mat[0].Length;
        Queue<int[]> ZeroPos = new Queue<int[]>();
        int max = col * len;
        
        for(int i = 0; i < len; i++)
        {
            for(int j = 0; j < col; j++)
            {
                if(mat[i][j] == 0)
                   ZeroPos.Enqueue(new int[] {i, j}); 
                else
                    mat[i][j] = max;
            }
        }
        
        int[] dRow = new int[] { 0, 0, 1, -1 },
              dCol = new int[] { 1, -1, 0, 0 };
        
        while(ZeroPos.Count > 0)
        {
            int[] cur = ZeroPos.Dequeue();
            for (int k = 0; k < 4; k++)
            {
                if (cur[0] + dRow[k] > -1 && cur[0] + dRow[k] < mat.Length && cur[1] + dCol[k] > -1 && cur[1] + dCol[k] < mat[0].Length && mat[cur[0] + dRow[k]][cur[1] + dCol[k]] > mat[cur[0]][cur[1]] + 1)
                {
                    mat[cur[0] + dRow[k]][cur[1] + dCol[k]] = mat[cur[0]][cur[1]] + 1;
                    ZeroPos.Enqueue(new int[] { cur[0] + dRow[k], cur[1] + dCol[k] });
                }
            }
        }
        return mat;
    }
}