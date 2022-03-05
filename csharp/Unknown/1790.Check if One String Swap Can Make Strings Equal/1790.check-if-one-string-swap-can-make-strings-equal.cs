/*
 * @lc app=leetcode id=1790 lang=csharp
 *
 * [1790] Check if One String Swap Can Make Strings Equal
 */

// @lc code=start
public class Solution
{
  public bool AreAlmostEqual(string s1, string s2)
  {
    if (s1.Length != s2.Length)
    {
      return false;
    }
    if (s1 == s2)
    {
      return true;
    }
    var index = 0;
    var diff = new int[2];
    for (int i = 0; i < s1.Length; i++)
    {
      if (s1[i] != s2[i])
      {
        if (index > 1)
        {
          return false;
        }
        diff[index] = i;
        index++;
      }
    }
    return index == 2 && s1[diff[0]] == s2[diff[1]] && s1[diff[1]] == s2[diff[0]];
  }
}
// @lc code=end

