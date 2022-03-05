/*
 * @lc app=leetcode id=1502 lang=csharp
 *
 * [1502] Can Make Arithmetic Progression From Sequence
 */

// @lc code=start
public class Solution
{
  public bool CanMakeArithmeticProgression(int[] arr)
  {
    if (arr.Length < 2)
    {
      return false;
    }
    Array.Sort(arr);
    var difference = arr[0] - arr[1];
    for (int i = 2; i < arr.Length; i++)
    {
      if (arr[i - 1] - arr[i] != difference)
      {
        return false;
      }
    }
    return true;
  }
}
// @lc code=end

