/*
 * @lc app=leetcode id=202 lang=csharp
 *
 * [202] Happy Number
 */

// @lc code=start
public class Solution
{
  public bool IsHappy(int n)
  {
    var hashSet = new HashSet<int>();
    while (n != 1)
    {
      if (hashSet.Contains(n))
      {
        return false;
      }
      hashSet.Add(n);
      var temp = 0;
      while (n != 0)
      {
        var remainder = n % 10;
        temp += remainder * remainder;
        n /= 10;
      }
      n = temp;
    }
    return true;
  }
}
// @lc code=end

