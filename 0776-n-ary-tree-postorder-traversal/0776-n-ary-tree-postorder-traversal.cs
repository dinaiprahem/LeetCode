/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Postorder(Node root) {
         List<int> result = new List<int>();
if (root == null) return result;

Stack<Node> stack1 = new Stack<Node>();
Stack<Node> r = new Stack<Node>();
stack1.Push(root);
while (stack1.Count > 0)
{
    Node current = stack1.Pop();
    r.Push(current);
    foreach (var item in current.children)
    {
        stack1.Push(item);
    }
}

foreach (var item in r)
{
    result.Add(item.val);
}
return result;
    }
}