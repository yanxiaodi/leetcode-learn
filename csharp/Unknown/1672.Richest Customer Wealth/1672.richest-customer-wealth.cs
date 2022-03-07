/*
 * @lc app=leetcode id=1672 lang=csharp
 *
 * [1672] Richest Customer Wealth
 */

// @lc code=start
public class Solution
{
  public int MaximumWealth(int[][] accounts)
  {
    var max = int.MinValue;
    foreach (var i in accounts)
    {
      var temp = 0;
      foreach (var j in i)
      {
        temp += j;
      }
      if (temp > max)
      {
        max = temp;
      }
    }
    return max;
  }
}
// @lc code=end

