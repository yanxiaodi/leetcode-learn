/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */

// @lc code=start
public class Solution
{
  public int RemoveDuplicates(int[] nums)
  {
    var slow = 0;
    if (nums.Length == 0)
    {
      return 0;
    }
    else if (nums.Length == 1)
    {
      return 1;
    }
    for (int fast = 1; fast < nums.Length; fast++)
    {
      if (nums[slow] != nums[fast])
      {
        slow++;
        nums[slow] = nums[fast];
      }
    }
    return slow + 1;
  }
}
// @lc code=end

