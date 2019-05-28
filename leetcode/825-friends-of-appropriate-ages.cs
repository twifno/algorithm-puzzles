//https://leetcode.com/problems/friends-of-appropriate-ages/

public class Solution {
    public int NumFriendRequests(int[] ages) {
        int[] counts = new int[121];
        foreach(int age in ages) {
            counts[age] += 1;
        }
        int count = 0;
        for(int i = 1; i <= 120; i++) {
            for(int j = i; j <= 120; j++){
                if(Good(i, j) && counts[i] > 0 && counts[j] > 0) {
                    if(i == j) count += counts[i] * (counts[j]-1);
                    else count += counts[i] * counts[j];
                }
            }
        }
        return count;
    }
    
    private bool Good(int i, int j) {
        if(i <= 0.5*j+7) return false;
        return true;
    }
}
