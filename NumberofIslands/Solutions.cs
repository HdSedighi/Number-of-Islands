class Solution
{
    // The function to count the number of islands in a grid
    public int NumIslands(char[][] grid)
    {
        // If the grid is null or empty, return 0
        if (grid == null || grid.Length == 0) return 0;

        int rows = grid.Length; // Number of rows in the grid
        int cols = grid[0].Length; // Number of columns in the grid
        int islandCount = 0; // Initialize the count of islands to 0

        // Iterate through each cell in the grid
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // If the cell contains '1' (land), explore the island
                if (grid[i][j] == '1')
                {
                    // Increase the count of islands
                    islandCount++;
                    // Explore the island using Depth First Search (DFS)
                    DFS(grid, i, j);
                }
            }
        }

        // Return the total count of islands
        return islandCount;
    }

    // Depth First Search (DFS) function to explore the island
    private void DFS(char[][] grid, int row, int col)
    {
        int rows = grid.Length; // Number of rows in the grid
        int cols = grid[0].Length; // Number of columns in the grid

        // If the cell is out of bounds or is water, return
        if (row < 0 || row >= rows || col < 0 || col >= cols || grid[row][col] == '0')
            return;

        // Mark the current cell as visited by changing it to '0' (water)
        grid[row][col] = '0';

        // Explore the four adjacent cells
        DFS(grid, row - 1, col); // Up
        DFS(grid, row + 1, col); // Down
        DFS(grid, row, col - 1); // Left
        DFS(grid, row, col + 1); // Right
    }
}
