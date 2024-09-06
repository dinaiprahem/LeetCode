// public class ListNode {
//     public int val;
//     public ListNode next;
//     public ListNode(int x) { val = x; }
// }

public class Solution {
    public ListNode ModifiedList(int[] nums, ListNode head) {
        // Convert nums array to a HashSet for faster lookup
        HashSet<int> toRemove = new HashSet<int>(nums);
        
        // Create a dummy node to simplify the head removal case
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        
        // Initialize pointers
        ListNode current = head;
        ListNode prev = dummy;

        // Traverse the linked list
        while (current != null) {
            if (toRemove.Contains(current.val)) {
                // Skip the current node by updating the previous node's next pointer
                prev.next = current.next;
            } else {
                // Move the prev pointer to the current node
                prev = current;
            }
            current = current.next;
        }

        // Return the modified list starting from the original head's position
        return dummy.next;
    }
}
