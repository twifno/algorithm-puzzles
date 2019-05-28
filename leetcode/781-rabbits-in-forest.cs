//https://leetcode.com/problems/rabbits-in-forest/

public class Solution {
    public int NumRabbits(int[] answers) {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        foreach(int a in answers) {
            if(!counts.ContainsKey(a)) counts[a] = 1;
            else counts[a] += 1;
        }
        int sum = 0;
        foreach(int a in counts.Keys){
            sum += counts[a] / (a+1) * (a+1);
            if(counts[a] % (a+1) != 0) sum += a+1; 
        }
        return sum;
    }
}
