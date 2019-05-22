//https://leetcode.com/problems/search-a-2d-matrix/

//Binary Search.

public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        int l0 = matrix.GetLength(0);
        int l1 = matrix.GetLength(1);
        int left = 0;
        int right = l1*l0-1;
        while(left <= right){
            int mid = left + (right-left)/2;
            int val = matrix[mid/l1, mid%l1];
            if(val == target) return true;
            else if(val < target) left = mid + 1;
            else right = mid - 1; 
        }
        return false;
    }
}
