//https://leetcode.com/problems/compare-version-numbers/

//Check case by case.

public class Solution {
    public int CompareVersion(string version1, string version2) {
        string[] v1 = version1.Split('.');
        string[] v2 = version2.Split('.');
        for(int i = 0; i < v1.Length; i++){
            if(i >= v2.Length && Int32.Parse(v1[i]) != 0) return 1;
            else if(i < v2.Length && Int32.Parse(v1[i]) > Int32.Parse(v2[i])) return 1;
            else if(i < v2.Length && Int32.Parse(v1[i]) < Int32.Parse(v2[i])) return -1;
        }
        for(int i = v1.Length; i < v2.Length; i++) {
            if(Int32.Parse(v2[i]) != 0) return -1;
        }
        return 0;
    }
}
