public class Solution {
    public int NearestExit(char[][] maze, int[] entrance) {
        int m = maze.Length, n = maze[0].Length;
        int steps = 0;
        Queue<int[]> queue = new Queue<int[]>();
        queue.Enqueue(entrance);
        int[,] dir = new int[,]{{-1,0}, {1,0}, {0,-1}, {0,1}};
        maze[entrance[0]][entrance[1]] = '*';

        while(queue.Count > 0)
        {
            steps++;
            int size = queue.Count;
            for(int i = 0; i < size; i++)
            {
                var curr = queue.Dequeue();
                for(int j = 0; j < 4; j++)
                {
                    int newRow = curr[0] + dir[j,0];
                    int newCol = curr[1] + dir[j,1];

                    if(newRow >= 0 && newRow < m && newCol >= 0 && newCol < n && maze[newRow][newCol] == '.')
                    {
                        if(newRow == m - 1 || newRow == 0 || newCol == n - 1 || newCol == 0)
                            return steps;
                        queue.Enqueue(new int[]{newRow, newCol});
                        maze[newRow][newCol] = '*';
                    }
                }
            }
        }
        return -1;
    }
}