/*
 * @lc app=leetcode id=1572 lang=csharp
 *
 * [1572] Matrix Diagonal Sum
 */

// @lc code=start
public class Solution
{
  public int DiagonalSum(int[][] mat)
  {
    var length = mat.Length;
    var sum = 0;
    for (int i = 0; i < length; i++)
    {
      sum += (mat[i][i] + mat[i][length - 1 - i]);
    }
    if (length % 2 > 0)
    {
      sum -= mat[length / 2][length / 2];
    }
    return sum;
  }
}
// @lc code=end

