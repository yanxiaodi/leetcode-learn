/*
 * @lc app=leetcode id=1768 lang=csharp
 *
 * [1768] Merge Strings Alternately
 */

// @lc code=start
using System.Text;

public class Solution
{
  public string MergeAlternately(string word1, string word2)
  {
    var sb = new StringBuilder();
    for (int i = 0; i < Math.Min(word1.Length, word2.Length); i++)
    {
      sb.Append(word1[i]);
      sb.Append(word2[i]);
    }
    if (word1.Length > word2.Length)
    {
      sb.Append(word1.Substring(word2.Length));
    }
    else
    {
      sb.Append(word2.Substring(word1.Length));
    }

    return sb.ToString();
  }
}
// @lc code=end

