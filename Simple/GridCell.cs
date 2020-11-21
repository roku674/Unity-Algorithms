using System;
using System.Collections;

/* Alexander Fields
 * Computer Science
 * 900817028
 * Created 13:07 EST 11/19/2020 
 */

public class GridCell
{
    /// <summary>
    /// Structure that holds an X and Y coordinate
    /// </summary>
    struct Coordinate{
        int row;
        int column;
    }

    /// <summary>
    /// Call FindNeighborhood to find the total number of cells in the  neighboorhood. Probably not the greatest way to do this i think its O(N^3) 
    /// </summary>
    /// <param name="grid">Pass in the grid, the grid itself cannot be [-1] or [0] also fill in each part of the grid with an integer no nulls allowed </param>
    /// <param name="n">Pass in the number for the distance threshhold</param>
    /// <param name="coordinate">Pass the Y coordinate in or coordinate for row</param>
    /// <returns>The number of total cells in the neighboorhood If -1 is returned then your grid wasn't correct. if -2 is returned then n was less than 0, if -3 was returned row or column in coordinate was less than 0. if -4 is returned the array of columns is invalid</returns>
    public int FindNeighborhood(int[][] grid, Coordinate[] coord, int n)
    {
        int neighboorhood;

        //if (CheckGrid(grid) == false) return -1; //checks if grid has nulls in it technically can comment this out this runetime alone is n^2
        if ((grid.GetLength(0) <= 0) && (grid.GetLength(1) <= 0)) return -1; //check gridlength
        if(n < 0) return -2; //checking condition comment out if uncessary
        if ((coord[k].row < 0) && (coord[k].column < 0)) return -3;//point of origin
        if (coordinate.GetLength <= 0) return -4;
         //check the coordinates to see if they're not out of bounds

        for(int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                for(int k = 0; k < coord.Length; k++)
                {
                    int manhattan = Math.Abs(coord[k].row - i) + Math.Abs(coord[k].column - j);

                    if ( manhattan <= n && manhattan >= 0 )
                    {
                        if (grid[i][j] == null) { }

                        else
                        {
                            grid[i][j] = null;
                            neighboorhood++;
                        }                        
                    }
                }
                
            }
        }

        return neighboorhood;
    } //end of findneighborhood

    bool CheckGrid(int[][] grid)
    {
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                if(grid[i][j] == null)
                {
                    return false;
                }
            }
        }
        return true;
    } //end of checkgrid

}//end of class
