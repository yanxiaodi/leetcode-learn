/*
 * @lc app=leetcode id=1232 lang=csharp
 *
 * [1232] Check If It Is a Straight Line
 */

// @lc code=start
public class Solution
{
  public bool CheckStraightLine(int[][] coordinates)
  {
    if (coordinates.Length == 2)
    {
      return true;
    }

    int x1 = coordinates[0][0] - coordinates[1][0];
    int y1 = coordinates[0][1] - coordinates[1][1];
    for (int i = 2; i < coordinates.Length; i++)
    {
      int x2 = coordinates[0][0] - coordinates[i][0];
      int y2 = coordinates[0][1] - coordinates[i][1];
      if (x1 * y2 != x2 * y1)
      {
        return false;
      }
    }
    return true;
  }
}
// @lc code=end

