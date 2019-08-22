public class RotateImage {
    public void Rotate(int[][] matrix) {
        int n = matrix.Length;
        
        for (int x = 0; x < n/2; x++)
            for (int y = x; y < n-x-1; y++)
            {
                int x1 = matrix[x]    [y];
                int x2 = matrix[y]    [n-x-1];
                int x3 = matrix[n-x-1][n-y-1];
                int x4 = matrix[n-y-1][x];

                matrix[x]    [y]     = x4;
                matrix[y]    [n-x-1] = x1;
                matrix[n-x-1][n-y-1] = x2;
                matrix[n-y-1][x]     = x3;
            }
    }
}
