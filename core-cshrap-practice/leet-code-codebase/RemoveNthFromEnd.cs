 
 public class ListNode{
    public int val;
    public ListNode next;

    public ListNode(int value = 0, ListNode nextNode = null)
    {
        val = value;
        next = nextNode;
    }
}

  public class  RemoveNthFromEnd {
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        // Dummy node to handle edge cases
        ListNode dummy = new ListNode(0);
        dummy.next = head;

        ListNode first = dummy;
        ListNode second = dummy;

        // Move first pointer n+1 steps ahead
        for (int i = 0; i <= n; i++)
        {
            first = first.next;
        }

        // Move both pointers until first reaches the end
        while (first != null)
        {
            first = first.next;
            second = second.next;
        }

        // Remove the nth node from end
        second.next = second.next.next;

        return dummy.next;
    }
}
