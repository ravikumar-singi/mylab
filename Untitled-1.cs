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
        ListNode current = head;
        ListNode nodeToDelete = null;
        int length = 1;
        while (current.next != null)
        {
            current = current.next;
            length++;
        }

        for (int i = 0; i < (length - n); i++)
        {
            nodeToDelete = head.next;
        }
        return nodeToDelete;

    }
}