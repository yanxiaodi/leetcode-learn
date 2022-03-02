/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution
{
  public bool IsPalindrome(int x)
  {
    if (x < 0 || x % 10 == 0)
    {
      return false;
    }
    else if (x == 0)
    {
      return true;
    }
    var copy = x;
    long result = 0;
    var temp = 0;
    while (x != 0)
    {
      temp = x % 10;
      x = x / 10;
      result = result * 10 + temp;
    }
    return (int)result == copy;
  }
}
// @lc code=end

