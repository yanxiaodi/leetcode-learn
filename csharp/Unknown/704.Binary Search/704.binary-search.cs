/*
 * @lc app=leetcode id=704 lang=csharp
 *
 * [704] Binary Search
 */

// @lc code=start
public class Solution
{
  public int Search(int[] nums, int target)
  {
    if (nums.Length == 0)
    {
      return -1;
    }
    int left = 0;
    int right = nums.Length - 1;
    // Left close, right close
    // Use <=
    while (left <= right)
    {
      var middle = left + (right - left) / 2;
      if (nums[middle] < target)
      {
        left = middle + 1;
      }
      else if (nums[middle] > target)
      {
        right = middle - 1;
      }
      else
      {
        return middle;
      }
    }
    // Left close, right open
    // int right = nums.Length;
    // while (left < right)
    // {
    //   var middle = left + (right - left) / 2;
    //   if (nums[middle] < target)
    //   {
    //     left = middle + 1;
    //   }
    //   else if (nums[middle] > target)
    //   {
    //     right = middle;
    //   }
    //   else
    //   {
    //     return middle;
    //   }
    // }
    return -1;
  }
}
// @lc code=end

