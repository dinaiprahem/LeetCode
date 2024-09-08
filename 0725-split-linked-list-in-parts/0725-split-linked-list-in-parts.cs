// public class ListNode {
//     public int val;
//     public ListNode next;
//     public ListNode(int val = 0, ListNode next = null) {
//         this.val = val;
//         this.next = next;
//     }
// }

public class Solution {
    public ListNode[] SplitListToParts(ListNode head, int k) {
       // length of list
        int length = 0;
        ListNode current = head;
        while (current != null) {
            length++;
            current = current.next;
        }
        
        
        int partSize = length / k;
        int extraNodes = length % k;
        
        // Prepare the result array
        ListNode[] result = new ListNode[k];
        current = head;
        
        for (int i = 0; i < k; i++) {
            // Initialize the head of the current part
            ListNode partHead = current;
            ListNode partTail = null;
            
            // Determine the size of the current part
            int currentPartSize = partSize ;
            if( extraNodes>0)
            {
                currentPartSize++;
                extraNodes--;
            }
            
            // Move to the end of the current part
            for (int j = 0; j < currentPartSize; j++) {
                partTail = current;
                current = current.next;
            }
            
            // Disconnect the current part from the rest of the list
            if (partTail != null) {
                partTail.next = null;
            }
            
            // Assign the current part to the result array
            result[i] = partHead;
        }
        
        return result;
    }
}
