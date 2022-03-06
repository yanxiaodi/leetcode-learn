/*
 * @lc app=leetcode id=203 lang=csharp
 *
 * [203] Remove Linked List Elements
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
  public ListNode RemoveElements(ListNode head, int val)
  {
    var newHead = new ListNode(0, head);

    var current = newHead;
    while (current.next != null)
    {
      if (current.next.val != val)
      {
        current = current.next;
      }
      else
      {
        current.next = current.next.next;
      }
    }
    return newHead.next;
  }
}
// @lc code=end

