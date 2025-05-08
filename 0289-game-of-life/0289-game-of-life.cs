public class Solution {
    public void GameOfLife(int[][] board) {
        int[,] dir = new int[,]{
            {1, 1}, 
            {1, 0}, 
            {1, -1}, 
            {0, -1}, 
            {0, 1}, 
            {-1, -1}, 
            {-1, 0}, 
            {-1, 1}  
        };
        
        int totalRows = board.Length;
        int totalCols = board[0].Length;
        
        for(int rowNo = 0; rowNo < totalRows; rowNo++)
        {
            for(int colNo = 0; colNo < totalCols; colNo++)
            {
                int liveCells = 0;
                for(int index = 0; index < 8; index++)
                {
                    int row = rowNo + dir[index, 0];
                    int col = colNo + dir[index, 1];
                    if(row >= 0 && row < totalRows && col >= 0 && col < totalCols && (board[row][col] == 1 || board[row][col] == -2))
                        liveCells++;
                }
                
                if(board[rowNo][colNo] == 0 && liveCells == 3)
                {
                    board[rowNo][colNo] = -3;
                }
                else if(board[rowNo][colNo] == 1 && (liveCells < 2 || liveCells > 3))
                {
                    board[rowNo][colNo] = -2;
                }
            }
        }
        
        for(int rowNo = 0; rowNo < totalRows; rowNo++)
        {
            for(int colNo = 0; colNo < totalCols; colNo++)
            {
                if(board[rowNo][colNo] == -2)
                {
                    board[rowNo][colNo] = 0;
                }
                else if(board[rowNo][colNo] == -3)
                {
                    board[rowNo][colNo] = 1;
                }
            }
        }
        
    }
}