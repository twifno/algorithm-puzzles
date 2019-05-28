//https://leetcode.com/problems/construct-binary-tree-from-string/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode Str2tree(string s) {
        if(s == "") return null;
        int firstPar = s.IndexOf('(');
        if(firstPar == -1) {
            return new TreeNode(Int32.Parse(s));
        }
        string valStr = s.Substring(0, firstPar);
        TreeNode node = new TreeNode(Int32.Parse(valStr));
        int count = 0;
        int pos = firstPar;
        while(pos < s.Length){
            if(s[pos] == '(') count += 1;
            else if(s[pos] == ')') count -= 1;
            if(count == 0) break;
            pos += 1;
        }
        if(pos - firstPar + 1 > 2){
            node.left = Str2tree(s.Substring(firstPar+1, pos-firstPar-1));
        }
        pos += 1;
        if(s.Length-pos > 2) {
            node.right = Str2tree(s.Substring(pos + 1, s.Length-pos-2));
        }
        return node;
    }
}
