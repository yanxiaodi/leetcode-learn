/*
 * @lc app=leetcode id=566 lang=csharp
 *
 * [566] Reshape the Matrix
 */

// @lc code=start
public class Solution
{
  public int[][] MatrixReshape(int[][] mat, int r, int c)
  {
    var m = mat.Length;
    var n = mat[0].Length;
    if (m * n != r * c)
    {
      return mat;
    }
    var result = new int[r][];
    for (int i = 0; i < result.Length; i++)
    {
      result[i] = new int[c];
      for (int j = 0; j < result[i].Length; j++)
      {
        var index = i * c + j;
        var m1 = index / n;
        var n1 = index - m1 * n;
        result[i][j] = mat[m1][n1];
      }
    }
    return result;
  }
}
// @lc code=end

