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
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsSubPath(ListNode head, TreeNode root) {
         if (root == null) return false;
       
        return DoesPathExist(root, head) || IsSubPath(head, root.left) || IsSubPath(head, root.     
        right);
    }
     private bool DoesPathExist(TreeNode node, ListNode head) {
        // If linked list is finished, return true
        if (head == null) return true;
        // If tree node is null or values do not match, return false
        if (node == null || node.val != head.val) return false;
        // Recur for left and right subtrees
        return DoesPathExist(node.left, head.next) || DoesPathExist(node.right, head.next);
    }
}