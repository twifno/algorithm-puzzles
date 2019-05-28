//https://leetcode.com/problems/find-k-closest-elements/

//Binary Search can also be done better.

public class Solution {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        int left = 0;
        int right = arr.Length-1;
        while(left <= right){
            int mid = left + (right-left)/2;
            if(arr[mid] <= x) left = mid+1;
            else right = mid-1;
        }
        if(left >= arr.Length) left = arr.Length-1;
        if(left > 0 && arr[left] > x) left -= 1;
        right = left + 1;
        List<int> res = new List<int>();
        for(int i = 0; i < k; i++){
            if(left < 0) {
                right += 1;
            } else if(right >= arr.Length) {
                left -= 1;
            } else if(Math.Abs(arr[left] - x) <= Math.Abs(arr[right] -x)){
                left -= 1;
            } else {
                right += 1;
            }
        }
        for(int i = left+1; i < right; i++) res.Add(arr[i]);
        return res;
    }
}
