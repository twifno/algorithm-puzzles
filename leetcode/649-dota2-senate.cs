//https://leetcode.com/problems/dota2-senate/

//Greedy

public class Solution {
    public string PredictPartyVictory(string senate) {
        int len = senate.Length;
        bool[] banned = new bool[len];
        while(true){
            for(int i = 0; i < len; i++){
                if(banned[i]) continue;
                bool ban = false;
                for(int j = 1; j < len; j++){
                    int pos = (i+j) % len;
                    if(!banned[pos] && senate[pos] != senate[i]) {
                        ban = true;
                        banned[pos] = true;
                        break;
                    }
                }
                if(!ban) {
                    if(senate[i] == 'R') return "Radiant";
                    else return "Dire";
                } 
            }
        }
        return "";
    }
}
