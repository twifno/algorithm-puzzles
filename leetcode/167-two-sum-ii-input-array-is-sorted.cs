//https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/

//Two point approach - know how to prove!

public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0; 
        int right = numbers.Length-1;
        while(numbers[left] + numbers[right] != target){
            if(numbers[left] + numbers[right] < target) left += 1;
            else right -= 1;
        }
        return new int[2] {left+1, right+1};
    }
}
