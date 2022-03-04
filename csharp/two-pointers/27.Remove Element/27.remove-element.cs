/*
 * @lc app=leetcode id=27 lang=csharp
 *
 * [27] Remove Element
 */

// @lc code=start
public class Solution
{
  public int RemoveElement(int[] nums, int val)
  {
    // Use two pointers
    int slowIndex = 0;
    for (int fastIndex = 0; fastIndex < nums.Length; fastIndex++)
    {
      if (nums[fastIndex] != val)
      {
        nums[slowIndex] = nums[fastIndex];
        slowIndex++;
      }
    }
    return slowIndex;

    // Two Pointers - when elements to remove are rare
    // var count = nums.Length;
    // var index = 0;
    // while (index < count)
    // {
    //   if (nums[index] == val)
    //   {
    //     nums[index] = nums[count - 1];
    //     count--;
    //   }
    //   else
    //   {
    //     index++;
    //   }
    // }
    // return count;

    // var count = nums.Length;
    // for (int i = 0; i < count; i++)
    // {
    //   if (nums[i] == val)
    //   {
    //     for (int j = i + 1; j < count; j++)
    //     {
    //       nums[j - 1] = nums[j];
    //     }
    //     i--;
    //     count--;
    //   }
    // }
    // return count;
  }
}
// @lc code=end

