/*
 * @lc app=leetcode id=1779 lang=csharp
 *
 * [1779] Find Nearest Point That Has the Same X or Y Coordinate
 */

// @lc code=start
public class Solution
{
  public int NearestValidPoint(int x, int y, int[][] points)
  {
    var index = -1;
    var smallestDistance = int.MaxValue;
    for (int i = 0; i < points.Length; i++)
    {
      var pointX = points[i][0];
      var pointY = points[i][1];
      if (pointX == x || pointY == y)
      {
        var distance = Math.Abs(x - pointX) + Math.Abs(y - pointY);
        if (distance < smallestDistance)
        {
          smallestDistance = distance;
          index = i;
        }
      }
    }
    return index;
  }
}
// @lc code=end

