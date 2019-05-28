//https://leetcode.com/problems/encode-n-ary-tree-to-binary-tree/

//Children to left tree and Siblings to right tree.

/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node(){}
    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
}
*/
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {

    // Encodes an n-ary tree to a binary tree.
    public TreeNode encode(Node root) {
        return BuildBinary(root, null);
    }
    
    public TreeNode BuildBinary(Node root, IList<Node> sibs){
        if(root == null) return null;
        TreeNode node = new TreeNode(root.val);
        if(sibs != null && sibs.Count > 0) {
            Node sib = sibs[0];
            sibs.RemoveAt(0);
            node.right = BuildBinary(sib, sibs);
        }
        if(root.children != null && root.children.Count > 0){
            Node c = root.children[0];
            root.children.RemoveAt(0);
            node.left = BuildBinary(c, root.children);
        }
        return node;
    }

    // Decodes your binary tree to an n-ary tree.
    public Node decode(TreeNode root) {
        if(root == null) return null;
        Node node = new Node(root.val, new List<Node>());
        if(root.left != null) {
            TreeNode c = root.left;
            while(c != null){
                node.children.Add(decode(c));
                c = c.right;
            }
        }
        return node;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(root));
