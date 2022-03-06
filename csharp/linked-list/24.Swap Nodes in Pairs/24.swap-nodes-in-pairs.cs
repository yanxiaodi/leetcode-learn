/*
 * @lc app=leetcode id=24 lang=csharp
 *
 * [24] Swap Nodes in Pairs
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
  public ListNode SwapPairs(ListNode head)
  {
    if (head == null)
    {
      return null;
    }
    else if (head.next == null)
    {
      return head;
    }

    ListNode newHead = new ListNode(0, head);
    var current = newHead;
    while (current.next != null && current.next.next != null)
    {
      var temp = current.next;
      var temp1 = current.next.next.next;
      current.next = temp.next;
      current.next.next = temp;
      current.next.next.next = temp1;
      current = current.next.next;
    }
    return newHead.next;
  }
}
// @lc code=end

