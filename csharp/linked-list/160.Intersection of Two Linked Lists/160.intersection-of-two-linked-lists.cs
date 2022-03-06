/*
 * @lc app=leetcode id=160 lang=csharp
 *
 * [160] Intersection of Two Linked Lists
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
  public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
  {
    ListNode currentA = headA;
    ListNode currentB = headB;
    int lengthA = 0;
    int lengthB = 0;
    while (currentA != null)
    {
      lengthA++;
      currentA = currentA.next;
    }
    while (currentB != null)
    {
      lengthB++;
      currentB = currentB.next;
    }
    currentA = headA;
    currentB = headB;
    if (lengthB > lengthA)
    {
      int tempLength = lengthA;
      lengthA = lengthB;
      lengthB = tempLength;
      var tempNode = currentA;
      currentA = currentB;
      currentB = tempNode;
    }
    int gap = lengthA - lengthB;
    while (gap > 0)
    {
      currentA = currentA.next;
      gap--;
    }
    while (currentA != null)
    {
      if (currentA == currentB)
      {
        return currentA;
      }
      currentA = currentA.next;
      currentB = currentB.next;
    }
    return null;
  }
}
// @lc code=end

