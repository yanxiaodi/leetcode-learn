/*
 * @lc app=leetcode id=191 lang=csharp
 *
 * [191] Number of 1 Bits
 */

// @lc code=start
public class Solution
{
  public int HammingWeight(uint n)
  {
    var count = 0;
    while (n != 0)
    {
      if ((n & 1) != 0)
      {
        count++;
      }
      n >>= 1;
    }
    return count;

    // var count = 0;
    // while (n != 0)
    // {
    //   n = n & (n - 1);
    //   count++;
    // }
    // return count;

    //return n.ToString().Replace("0", "").Length;

    // var count = 0;
    // uint test = 1;
    // for (int i = 0; i < 32; i++)
    // {
    //   if ((test & n) != 0)
    //   {
    //     count++;
    //   }
    //   test <<= 1;
    // }
    // return count;
  }
}
// @lc code=end

