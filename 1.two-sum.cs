/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int, int>();
        var result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(nums[i]))
            {
                result[0] = i;
                result[1] = dic[nums[i]];
            }
            dic[target - nums[i]] = i;
        }
        return result;
    }
}
// @lc code=end

