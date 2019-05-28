//https://leetcode.com/problems/k-closest-points-to-origin/

public class Solution {
    public int[][] KClosest(int[][] points, int K) {
        int[][] res = new int[K][];
        QuickSelect(0, points.Length-1, K-1, points);
        for(int i = 0; i < K; i++){
            res[i] = new int[2];
            res[i][0] = points[i][0];
            res[i][1] = points[i][1];
        }
        return res;
    }
    
    private void QuickSelect(int l, int r, int k, int[][] points){
        int cur = l;
        int pivot = r;
        for(int i = l; i <= r-1; i++){
            if(Dist(points[i]) <= Dist(points[pivot])) {
                Swap(points[i], points[cur]);
                cur += 1;
            }
        }
        Swap(points[cur], points[pivot]);
        if(cur == k) return;
        else if (cur < k) QuickSelect(cur+1, r, k, points);
        else QuickSelect(l, cur-1, k, points);
    }
    
    private void Swap(int[] p1, int[] p2){
        int tmp = p1[0];
        p1[0] = p2[0];
        p2[0] = tmp;
        tmp = p1[1];
        p1[1] = p2[1];
        p2[1] = tmp;
    }
    
    private int Dist(int[] p){
        return p[0] * p[0] + p[1] * p[1]; 
    }
}
