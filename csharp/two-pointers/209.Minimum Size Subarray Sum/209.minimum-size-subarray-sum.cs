/*
 * @lc app=leetcode id=209 lang=csharp
 *
 * [209] Minimum Size Subarray Sum
 */

// @lc code=start
public class Solution
{
  public int MinSubArrayLen(int target, int[] nums)
  {
    int left = 0;
    int sum = 0;
    int result = int.MaxValue;

    for (int right = 0; right < nums.Length; right++)
    {
      sum += nums[right];
      while (sum >= target)
      {
        var length = right - left + 1;
        result = result < length ? result : length;
        sum -= nums[left++];
      }
    }
    return result == int.MaxValue ? 0 : result;
  }
}
// @lc code=end

