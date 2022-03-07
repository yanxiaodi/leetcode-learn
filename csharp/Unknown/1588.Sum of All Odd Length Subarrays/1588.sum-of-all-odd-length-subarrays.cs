/*
 * @lc app=leetcode id=1588 lang=csharp
 *
 * [1588] Sum of All Odd Length Subarrays
 */

// @lc code=start
public class Solution
{
  public int SumOddLengthSubarrays(int[] arr)
  {
    if (arr.Length == 0)
    {
      return 0;
    }
    var result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
      var temp = 0;
      for (int j = i; j < arr.Length; j++)
      {
        temp += arr[j];
        if ((j - i + 1) % 2 > 0)
        {
          result += temp;
        }
      }
    }
    return result;
  }
}
// @lc code=end

