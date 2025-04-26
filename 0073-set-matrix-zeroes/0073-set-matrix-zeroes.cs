public class Solution {
    public void SetZeroes(int[][] matrix) {
        
        var row_Length = matrix.Length;
        var column_Length = matrix[0].Length;
        bool isfirstZero = false;
        
        for(int i = 0; i < row_Length; i++)
        {
            if(matrix[i][0] == 0)
                isfirstZero = true;
            
            for(int j = 1; j < column_Length; j++)
            {
                if(matrix[i][j] == 0)
                {
                    matrix[i][0] = 0;
                    matrix[0][j] = 0;
                }
            }
        }
        
        for(int i = 1; i < row_Length; i++)
        {
            for(int j = 1; j < column_Length; j++)
            {
                if(matrix[i][0] == 0 || matrix[0][j] == 0)
                {
                    matrix[i][j] = 0;
                }
            }
        }
        
        if(matrix[0][0] == 0)
        {
            for (int i = 0; i < column_Length; i++) {
                 matrix[0][i] = 0;
            }
        }
        
        if(isfirstZero)
        {
             for (int i = 0; i < row_Length; i++) {
                 matrix[i][0] = 0;  
            }
        }
    }
}