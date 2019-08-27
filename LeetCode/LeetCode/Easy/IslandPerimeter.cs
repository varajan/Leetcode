public class IslandPerimeter {
    public int GetIslandPerimeter(int[][] grid) {
        int result = 0;
        
        for (int x = 0; x < grid.Length; x++)
            for (int y = 0; y < grid[0].Length; y++)
                if (grid[x][y] == 1)
                    result += GetBorders(x, y);
        
        return result;
        
        int GetBorders(int x, int y)
        {
            int neighborhoods = 0;
            
            if (x > 0 && grid[x-1][y] == 1) neighborhoods++;
            if (y > 0 && grid[x][y-1] == 1) neighborhoods++;
            if (x < grid.Length - 1 && grid[x + 1][y] == 1) neighborhoods++;
            if (y < grid[0].Length - 1 && grid[x][y + 1] == 1) neighborhoods++;
            
            return 4 - neighborhoods;
        }
    }
}
