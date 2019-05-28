//https://leetcode.com/problems/lonely-pixel-ii/

public class Solution {
    public int FindBlackPixel(char[,] picture, int N) {
        int l0 = picture.GetLength(0);
        int l1 = picture.GetLength(1);
        string[] rowStrs = new string[l0];
        int[] rowCounts = new int[l0];
        for(int i = 0; i < l0; i++){
            char[] row = new char[l1];
            for(int j = 0; j < l1; j++) {
                row[j] = picture[i, j];
                if(row[j] == 'B') rowCounts[i] += 1;
            }
            rowStrs[i] = string.Join("", row);
        }
        int sum = 0;
        for(int j = 0; j < l1; j++){
            List<int> pos = new List<int>();
            for(int i = 0; i < l0; i++) {
                if(picture[i, j] == 'B') pos.Add(i);
            }
            if(pos.Count != N) continue;
            bool matched = true;
            for(int i = 0; i < pos.Count; i++){
                if(rowCounts[pos[i]] != pos.Count || rowStrs[pos[0]] != rowStrs[pos[i]]) {
                    matched = false;
                    break;
                }
            }
            if(matched) sum += pos.Count;
        }
        return sum;
    }
}
