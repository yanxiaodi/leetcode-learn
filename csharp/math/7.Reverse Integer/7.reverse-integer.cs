/*
 * @lc app=leetcode id=7 lang=csharp
 *
 * [7] Reverse Integer
 */

// @lc code=start
public class Solution
{
  public int Reverse(int x)
  {
    if (x == 0)
    {
      return 0;
    }
    long result = 0;
    var temp = 0;
    while (x != 0)
    {
      temp = x % 10;
      x = x / 10;
      result = result * 10 + temp;
      if (result > int.MaxValue || result < int.MinValue)
      {
        return 0;
      }
    }
    return (int)result;
  }
}
// @lc code=end

