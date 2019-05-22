//https://leetcode.com/problems/container-with-most-water/

//Two point approach O(n)

public class Solution {
    public int MaxArea(int[] height) {
        int l = 0;
        int r = height.Length - 1;
        int maxArea = 0;
        while(l < r){
            int lh = height[l];
            int rh = height[r];
            maxArea = Math.Max(maxArea, Math.Min(lh, rh) * (r-l));
            if(lh < rh) l += 1;
            else r -= 1;
        }
        return maxArea;
    }
}

//My Solution nlog(n), handle higher container first

public class Solution {
    private class Node {
        public int h;
        public int pos;
        public Node (int h, int pos){
            this.h = h;
            this.pos = pos;
        }
    }
    public int MaxArea(int[] height) {
        List<Node> nl = new List<Node>();
        for(int i = 0; i < height.Length; i++){
            nl.Add(new Node(height[i], i));
        }
        nl.Sort((x,y) => y.h.CompareTo(x.h));
        int l = -1;
        int r = -1;
        int maxArea = 0;
        foreach(Node n in nl){
            if(l == -1) {
                l = n.pos;
                r = n.pos;
            } else if (n.pos < l) {
                maxArea = Math.Max(maxArea, n.h * (r - n.pos));
                l = n.pos;
            } else if (n.pos > r) {
                maxArea = Math.Max(maxArea, n.h * (n.pos - l));
                r = n.pos;
            }
        }
        return maxArea;
    }
}
