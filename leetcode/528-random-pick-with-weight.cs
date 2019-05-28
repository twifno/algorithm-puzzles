//https://leetcode.com/problems/random-pick-with-weight/

//Binary search

public class Solution {

    int[] Sums;
    int Sum;
    Random Rand;
    
    public Solution(int[] w) {
        Sums = new int[w.Length];
        Sum = 0;
        for(int i = 0; i < w.Length; i++){
            Sum += w[i];
            Sums[i] = Sum;
        }
        Rand = new Random();
    }
    
    public int PickIndex() {
        int next = Rand.Next(Sum);
        int left = 0;
        int right = Sums.Length-1;
        while(left <= right){
            int mid = left + (right-left)/2;
            if(Sums[mid] == next) return mid+1;
            else if(Sums[mid] < next) left = mid + 1;
            else right = mid-1;
        }
        if(Sums[left] > next) return left;
        else return left + 1;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(w);
 * int param_1 = obj.PickIndex();
 */
