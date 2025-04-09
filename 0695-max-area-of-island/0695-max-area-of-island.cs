public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int maxArea = 0;
        Stack<int[]> data = new Stack<int[]>();
        int rowLen = grid.Length;
        int colLen = grid[0].Length;
        int[][] visited = new int[rowLen][];
        for(int i = 0; i < rowLen; i++)
            visited[i] = new int[colLen];
        
        int[] dr = new int[]{1, -1, 0, 0};
        int[] dc = new int[]{0, 0, 1, -1};
        
        for (int row = 0; row < rowLen; row++) 
        {
            for (int col = 0; col < colLen; col++) 
            {
                if(grid[row][col] == 1 && visited[row][col] != 1)
                {
                    int currMax = 0;
                    data.Push(new int[] {row, col});
                    visited[row][col] = 1;
                    while(data.Count > 0)
                    {
                        int[] cell = data.Pop();                
                        for(int k = 0; k < 4; k++)
                        {
                            int r = cell[0] + dr[k];
                            int c = cell[1] + dc[k];
                            if (0 <= r && r < rowLen &&
                                        0 <= c && c < colLen &&
                                        grid[r][c] == 1 && visited[r][c] != 1) 
                            {
                                    data.Push(new int[]{r, c});
                                    visited[r][c] = 1;
                            }
                        } 
                        currMax++;
                    }
                    maxArea = Math.Max(maxArea, currMax);
                }
          }
        }
        return maxArea;
    }
}