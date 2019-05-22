//https://leetcode.com/problems/candy/

//Solved by greedy.. May not be intuitive…

public class Solution {
    public int Candy(int[] ratings) {
        if(ratings.Length == 0) return 0;
        int[] c = new int[ratings.Length];
        c[0] = 1;
        for(int i = 1; i < ratings.Length; i++){
            if(ratings[i-1] < ratings[i]) c[i] = c[i-1]+1;
            else c[i] = 1;
        }
        for(int i = ratings.Length-2; i >= 0; i--){
            if(ratings[i+1] < ratings[i]) c[i] = Math.Max(c[i+1]+1, c[i]);
        }
        int sum = 0;
        for(int i = 0; i < ratings.Length; i++) sum += c[i];
        return sum;
    }
}
