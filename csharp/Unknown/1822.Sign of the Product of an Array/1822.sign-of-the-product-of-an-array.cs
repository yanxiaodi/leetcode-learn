/*
 * @lc app=leetcode id=1822 lang=csharp
 *
 * [1822] Sign of the Product of an Array
 */

// @lc code=start
public class Solution
{
  public int ArraySign(int[] nums)
  {
    var negative = 0;
    foreach (var num in nums)
    {
      if (num == 0)
      {
        return 0;
      }
      else if (num < 0)
      {
        negative += 1;
      }
    }
    return negative % 2 == 0 ? 1 : -1;
  }
}
// @lc code=end

