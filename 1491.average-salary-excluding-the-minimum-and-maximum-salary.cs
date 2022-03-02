/*
 * @lc app=leetcode id=1491 lang=csharp
 *
 * [1491] Average Salary Excluding the Minimum and Maximum Salary
 */

// @lc code=start
public class Solution
{
  public double Average(int[] salary)
  {
    var max = salary[0];
    var min = max;
    var sum = 0;
    foreach (var item in salary)
    {
      min = item < min ? item : min;
      max = item > max ? item : max;
      sum += item;
    }
    return (double)(sum - max - min) / (salary.Length - 2);
  }
}
// @lc code=end

