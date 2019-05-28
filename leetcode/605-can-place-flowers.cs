//https://leetcode.com/problems/can-place-flowers/

public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int max = 0;
        for(int i = 0; i < flowerbed.Length; i++) {
            if(flowerbed[i] == 0){
                if(i > 0 && flowerbed[i-1] == 1) continue;
                if(i < flowerbed.Length-1 && flowerbed[i+1] == 1) continue;
                flowerbed[i] = 1;
                max += 1;
            }
        }
        return max >= n;
    }
}
