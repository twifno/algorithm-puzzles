//https://leetcode.com/problems/serialize-and-deserialize-binary-tree/

//Just choose a way to traverse.

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

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        Queue<TreeNode> q = new Queue<TreeNode>();
        StringBuilder sb = new StringBuilder();
        q.Enqueue(root);
        while(q.Count > 0){
            TreeNode node = q.Dequeue();
            if(node == null) {
                sb.Append('n');
            } else {
                sb.Append(node.val);
                q.Enqueue(node.left);
                q.Enqueue(node.right);
            }
            sb.Append(',');
        }
        string res = sb.ToString();
        res = res.TrimEnd(',');
        //System.Console.WriteLine(res);
        return res;
    }   
        
    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        if(data == "n") return null;
        string[] tokens = data.Split(',');
        Queue<TreeNode> q = new Queue<TreeNode>();
        TreeNode head = new TreeNode(Int32.Parse(tokens[0]));
        q.Enqueue(head);
        int cur = 1;
        while(cur < tokens.Length){
            TreeNode node = q.Dequeue();
            if(tokens[cur] != "n") node.left = new TreeNode(Int32.Parse(tokens[cur]));
            if(tokens[cur+1] != "n") node.right = new TreeNode(Int32.Parse(tokens[cur+1]));
            cur += 2;
            if(node.left != null) q.Enqueue(node.left);
            if(node.right != null) q.Enqueue(node.right);
        }
        return head;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));
