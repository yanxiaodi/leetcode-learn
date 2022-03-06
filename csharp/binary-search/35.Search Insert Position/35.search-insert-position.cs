/*
 * @lc app=leetcode id=35 lang=csharp
 *
 * [35] Search Insert Position
 */

// @lc code=start
public class Solution
{
  public int SearchInsert(int[] nums, int target)
  {
    if (nums.Length == 0)
    {
      return 0;
    }
    if (target < nums[0])
    {
      return 0;
    }
    else if (target > nums.Last())
    {
      return nums.Length;
    }
    var left = 0;
    var right = nums.Length - 1;
    while (left <= right)
    {
      var mid = left + (right - left) / 2;
      if (target < nums[mid])
      {
        right = mid - 1;
      }
      else if (target > nums[mid])
      {
        left = mid + 1;
      }
      else
      {
        return mid;
      }
    }
    return left;


    // for (int i = 0; i < nums.Length; i++)
    // {
    //   if (nums[i] == target || nums[i] > target)
    //   {
    //     return i;
    //   }
    // }
    // return nums.Length;
  }
}
// @lc code=end

