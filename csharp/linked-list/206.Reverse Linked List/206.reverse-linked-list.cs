/*
 * @lc app=leetcode id=206 lang=csharp
 *
 * [206] Reverse Linked List
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
  public ListNode ReverseList(ListNode head)
  {
    ListNode pre = null;
    var current = head;
    while (current != null)
    {
      var temp = current.next;
      current.next = pre;
      pre = current;
      current = temp;
    }
    return pre;
  }
}
// @lc code=end

