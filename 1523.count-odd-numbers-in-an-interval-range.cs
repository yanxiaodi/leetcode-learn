/*
 * @lc app=leetcode id=1523 lang=csharp
 *
 * [1523] Count Odd Numbers in an Interval Range
 */

// @lc code=start
public class Solution
{
  public int CountOdds(int low, int high)
  {
    var diff = high - low;
    if ((diff + 1) % 2 == 0)
    {
      return (diff + 1) / 2;
    }
    var result = diff / 2;
    if (low % 2 > 0)
    {
      return result + 1;
    }
    return result;

  }
}
// @lc code=end

