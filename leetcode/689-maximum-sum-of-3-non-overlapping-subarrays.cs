//https://leetcode.com/problems/maximum-sum-of-3-non-overlapping-subarrays/

//3 -> start from middle

public class Solution {
    public int[] MaxSumOfThreeSubarrays(int[] nums, int k) {
        int len = nums.Length;
        int[] sums = new int[len];
        int[] subs = new int[len];
        int[] nsubs = new int[len];
        int[] submax = new int[len];
        int[] nsubmax = new int[len];
        int sum = 0;
        int maxsub = 0;
        int maxpos = 0;
        for(int i = 0; i < nums.Length; i++){
            sum += nums[i];
            sums[i] = sum;
            if(i == k-1) { subs[i] = sum; nsubs[0] = sum;}
            else if(i > k-1) {
                subs[i] = sum - sums[i-k];
                nsubs[i-k+1] = subs[i];
            }
            if(i >= k-1) {
                if(maxsub < subs[i]){
                    maxsub = subs[i];
                    maxpos = i;
                }
                submax[i] = maxpos;
            }
        }
        int maxnsub = 0;
        maxpos = 0;
        for(int i = len-k; i >= 0; i--){
            if(maxnsub < nsubs[i]){
                maxnsub = nsubs[i];
                maxpos = i;
            }
            nsubmax[i] = maxpos;
        }
        //foreach(int m in subs) System.Console.WriteLine(m);
        //foreach(int m in submax) System.Console.WriteLine(m);
        int max = 0;
        int[] res = {0, 0, 0};
        for(int i = 2*k-1; i < len-k; i++) {
            if(max < subs[submax[i-k]] + subs[i] + nsubs[nsubmax[i+1]]){
                max = subs[submax[i-k]] + subs[i] + nsubs[nsubmax[i+1]];
                res = new int[]{submax[i-k]-k+1, i-k+1, nsubmax[i+1]};
            }
        }
        return res;
    }
}
