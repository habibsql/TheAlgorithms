/*
Rat in a Maze problem:
Given N*N binary matrix where source block is upper left block maze[0,0] and distination blokc is lower right block maze[N-1, N-1]
A rat start from source to destination. The rat can move only right/forward or down direction. Findout the path.

Input: 
{1, 0, 0, 0}
{1, 1, 0, 1}
{0, 1, 0, 0}
{1, 1, 1, 1}

Output:
{1, 0, 0, 0}
{1, 1, 0, 1}
{0, 1, 0, 0}
{0, 1, 1, 1}

*/
namespace TheAlgorithms.Backtracking
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Backgracking
    {
        private int N;

        public int[,] SolveMaze(int[,] maze, int n)
        {
            this.N = n;
            var sol = new int[4, 4];

            SolveMazeInner(maze, 0, 0, sol);

            return sol;
        }

        private bool SolveMazeInner(int[,] maze, int x, int y, int[,] sol)
        {
            if (x == N-1 && y== N-1 && maze[x,y] == 1)
            {
                sol[x, y] = 1;
                return true;
            }
            if (!IsSafe(maze, x, y))
            {
                return false;
            }

            sol[x, y] = 1;

            // move to X direction
            if (SolveMazeInner(maze, x, y+1, sol))
            {
                return true;
            }
            // move to Y direction when x direction is not the solution
            if (SolveMazeInner(maze, x+ 1, y, sol))
            {
                return true;
            }

            sol[x, y] = 0;

            return false;
        }

        private bool IsSafe(int[,] maze, int x, int y)
        {
            return x >= 0 && x < N && y >= 0 && y < N && maze[x, y] == 1; 
        }

    }
}
