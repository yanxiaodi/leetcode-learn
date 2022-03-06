/*
 * @lc app=leetcode id=496 lang=csharp
 *
 * [496] Next Greater Element I
 */

// @lc code=start
public class Solution
{
  public int[] NextGreaterElement(int[] nums1, int[] nums2)
  {
    var dic = new Dictionary<int, int>();
    var stack = new Stack<int>();
    var result = new int[nums1.Length];
    foreach (var item in nums2)
    {
      while (stack.Count > 0 && stack.Peek() < item)
      {
        dic.Add(stack.Pop(), item);
      }
      stack.Push(item);
    }
    for (int i = 0; i < nums1.Length; i++)
    {
      result[i] = dic.ContainsKey(nums1[i]) ? dic[nums1[i]] : -1;
    }
    return result;
  }
}
// @lc code=end

