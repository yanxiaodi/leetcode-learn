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
    var sum = 0;
    var sub = 1;
    var n = arr.Length;
    while (sub <= n)
    {
      int temp = 0;
      for (int i = 0; i < sub; i++)
      {
        temp += arr[i];
      }
      sum += temp;
      for (int i = 0; i < n - sub; i++)
      {
        temp += arr[i + sub] - arr[i];
        sum += temp;
      }
      sub += 2;
    }
    return sum;

    // var result = 0;
    // for (int i = 0; i < arr.Length; i++)
    // {
    //   var temp = 0;
    //   for (int j = i; j < arr.Length; j++)
    //   {
    //     temp += arr[j];
    //     if ((j - i + 1) % 2 > 0)
    //     {
    //       result += temp;
    //     }
    //   }
    // }
    // return result;
  }
}
// @lc code=end

