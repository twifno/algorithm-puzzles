//https://leetcode.com/problems/most-frequent-subtree-sum/

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
    class Freq{
        public int Sum;
        public int Count;
        public Freq(int s, int c){
            Sum = s;
            Count = c;
        }
    }
    
    public int[] FindFrequentTreeSum(TreeNode root) {
        if(root == null) return new int[0];
        Dictionary<int, Freq> freqs = new Dictionary<int, Freq>();
        FindSum(root, freqs);
        List<Freq> freqsList = new List<Freq>(freqs.Values);
        freqsList.Sort((x, y) => y.Count.CompareTo(x.Count));
        List<int> res = new List<int>();
        int max = freqsList[0].Count;
        foreach(Freq f in freqsList) if(f.Count == max) res.Add(f.Sum);
        return res.ToArray();
    }
    
    private int FindSum(TreeNode root, Dictionary<int, Freq> freqs){
        if(root == null) return 0;
        int sum = root.val;
        sum += FindSum(root.left, freqs);
        sum += FindSum(root.right, freqs);
        if(!freqs.ContainsKey(sum)) freqs[sum] = new Freq(sum, 1);
        else freqs[sum].Count += 1;
        return sum;
    }
}
