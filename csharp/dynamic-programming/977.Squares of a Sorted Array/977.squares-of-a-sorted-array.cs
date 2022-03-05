/*
 * @lc app=leetcode id=977 lang=csharp
 *
 * [977] Squares of a Sorted Array
 */

// @lc code=start
public class Solution
{
  public int[] SortedSquares(int[] nums)
  {
    int left = 0;
    int right = nums.Length - 1;
    int k = nums.Length - 1;
    var result = new int[nums.Length];
    while (left <= right)
    {
      if (nums[left] * nums[left] < nums[right] * nums[right])
      {
        result[k] = nums[right] * nums[right];
        right--;
      }
      else
      {
        result[k] = nums[left] * nums[left];
        left++;
      }
      k--;
    }
    return result;
  }
}
// @lc code=end

