//https://leetcode.com/problems/serialize-and-deserialize-bst/

//General tree serialization and deserialization.
//You can use the fact of BST to make it faster
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
        if(root == null) return "";
        return root.val.ToString() + "?" + serialize(root.left) + ":" + serialize(root.right);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        if(data == "") return null;
        int qm = data.IndexOf("?");
        string valStr = data.Substring(0, qm);
        TreeNode node = new TreeNode(Int32.Parse(valStr));
        int count = 0;
        int pos = qm+1;
        while(pos < data.Length){
            if(data[pos] == '?') count += 1;
            else if(data[pos] == ':') {
                if(count == 0) break;
                else count -= 1;
            }
            pos += 1;
        }
        node.left = deserialize(data.Substring(qm+1, pos-qm-1));
        node.right = deserialize(data.Substring(pos+1, data.Length-pos-1));
        return node;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));
