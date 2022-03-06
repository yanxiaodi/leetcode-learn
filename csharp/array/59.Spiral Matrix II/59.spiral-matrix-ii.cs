/*
 * @lc app=leetcode id=59 lang=csharp
 *
 * [59] Spiral Matrix II
 */

// @lc code=start
public class Solution
{
  public int[][] GenerateMatrix(int n)
  {
    int[][] result = new int[n][];
    for (int index = 0; index < n; index++)
    {
      result[index] = new int[n];
    }
    var loop = n / 2;
    var startX = 0;
    var startY = 0;
    var mid = n / 2;
    var count = 1;
    var offset = 1;
    var i = 0;
    var j = 0;

    while (loop > 0)
    {
      i = startX;
      j = startY;
      for (j = startY; j < startY + n - offset; j++)
      {
        result[startX][j] = count++;
      }
      for (i = startX; i < startX + n - offset; i++)
      {
        result[i][j] = count++;
      }
      for (; j > startX; j--)
      {
        result[i][j] = count++;
      }
      for (; i > startX; i--)
      {
        result[i][j] = count++;
      }
      startX++;
      startY++;
      offset += 2;
      loop--;
    }
    if (n % 2 > 0)
    {
      result[mid][mid] = n * n;
    }
    return result;
  }
}
// @lc code=end

