/*
 * @lc app=leetcode id=19 lang=csharp
 *
 * [19] Remove Nth Node From End of List
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
  public ListNode RemoveNthFromEnd(ListNode head, int n)
  {
    var newHead = new ListNode(0, head);
    var slow = newHead;
    var fast = newHead;
    for (int i = 0; i < n; i++)
    {
      fast = fast.next;
    }
    fast = fast.next;
    while (fast != null)
    {
      fast = fast.next;
      slow = slow.next;
    }
    slow.next = slow.next.next;
    return newHead.next;
  }
}
// @lc code=end

