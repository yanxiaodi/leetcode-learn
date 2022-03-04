/*
 * @lc app=leetcode id=976 lang=csharp
 *
 * [976] Largest Perimeter Triangle
 */

// @lc code=start
public class Solution
{
  public int LargestPerimeter(int[] nums)
  {
    Array.Sort(nums);
    for (int i = nums.Length - 3; i >= 0; i--)
    {
      if (nums[i] + nums[i + 1] > nums[i + 2])
      {
        return nums[i] + nums[i + 1] + nums[i + 2];
      }
    }
    return 0;
  }
}
// @lc code=end

