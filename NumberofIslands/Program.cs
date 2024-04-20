﻿internal class Program{
 static void Main()
    {
        // Example usage:
        char[][] grid = new char[][]
        {
            new char[] { '1', '1', '0', '0', '0' },
            new char[] { '1', '1', '0', '0', '0' },
            new char[] { '0', '0', '1', '0', '0' },
            new char[] { '0', '0', '0', '1', '1' }
        };

        Solution solution = new Solution();
        int islandCount = solution.NumIslands(grid);

        Console.WriteLine("Number of islands: " + islandCount);
    }

}