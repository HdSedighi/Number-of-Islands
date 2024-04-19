# Intuition
The problem involves counting the number of islands in a 2D grid map of land and water. An island is a group of connected lands (horizontally or vertically) surrounded by water. To solve this problem, we can use a graph traversal algorithm such as Depth First Search (DFS) or Breadth First Search (BFS). When we encounter land (a '1'), we start a traversal from that point to explore the entire island and mark the visited lands as water (or '0') to avoid counting the same island multiple times. This way, each time we encounter a new land cell, it represents a new island.

# Approach
1. Initialization: Initialize a counter to keep track of the number of islands. Check for edge cases where the grid is null or empty.
2. Grid Traversal: Iterate through each cell in the 2D grid.
3. Land Encounter: When you encounter a land cell (a '1'), it represents the start of a new island.
4. Increase Counter: Increase the island counter and use a DFS function to explore the island.
5. DFS Exploration: The DFS function explores the island recursively, marking visited land cells as water (changing '1' to '0') to prevent revisiting them.
6. Exploration Directions: From each land cell, explore the four possible directions (up, down, left, right).
7. Return Count: After exploring the entire grid, return the island count.
# Complexity
-Time complexity: The algorithm needs to traverse each cell in the grid once to explore all the islands. Therefore, the time complexity is O(m×n), where m is the number of rows and n is the number of columns in the grid.

-Space complexity: The space complexity is determined by the maximum depth of the recursion stack during the DFS exploration. In the worst case, it could be the total number of cells in the grid. Therefore, the space complexity is also O(m×n).

__________________________________________________________________________________________
# Create a new console project
dotnet new console -n Number of Islands

# Run the project
dotnet run
