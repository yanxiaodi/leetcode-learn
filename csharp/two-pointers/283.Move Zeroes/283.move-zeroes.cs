/*
 * @lc app=leetcode id=283 lang=csharp
 *
 * [283] Move Zeroes
 */

// @lc code=start
public class Solution
{
  public void MoveZeroes(int[] nums)
  {
    var slow = 0;
    for (int fast = 0; fast < nums.Length; fast++)
    {
      if (nums[fast] != 0)
      {
        nums[slow] = nums[fast];
        slow += 1;
      }
    }
    for (int i = slow; i < nums.Length; i++)
    {
      nums[i] = 0;
    }
  }
}
// @lc code=end

