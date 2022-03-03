/*
 * @lc app=leetcode id=1281 lang=csharp
 *
 * [1281] Subtract the Product and Sum of Digits of an Integer
 */

// @lc code=start
public class Solution
{
  public int SubtractProductAndSum(int n)
  {
    if (n == 0)
    {
      return 0;
    }
    var product = 1;
    var sum = 0;
    while (n > 0)
    {
      var temp = n % 10;
      n /= 10;
      product *= temp;
      sum += temp;
    }
    return product - sum;
  }
}
// @lc code=end

