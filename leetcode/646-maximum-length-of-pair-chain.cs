//https://leetcode.com/problems/maximum-length-of-pair-chain/

//Greedy

public class Solution {
    public int FindLongestChain(int[,] pairs) {
        List<Tuple<int, int>> list = new List<Tuple<int, int>>();
        for(int i = 0; i < pairs.GetLength(0); i++){
            list.Add(new Tuple<int, int>(pairs[i, 0], pairs[i, 1]));
        }
        list.Sort((x, y) => x.Item2.CompareTo(y.Item2));
        int last = Int32.MinValue;
        int count = 0;
        foreach(Tuple<int, int> t in list){
            if(t.Item1 >= last) {
                count += 1;
                last = t.Item2 + 1;
            }
        }
        return count;
    }
}
