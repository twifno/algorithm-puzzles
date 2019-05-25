//https://leetcode.com/problems/find-the-celebrity/

//One edge can eliminate one node at a time.

/* The Knows API is defined in the parent class Relation.
      bool Knows(int a, int b); */

public class Solution : Relation {
    public int FindCelebrity(int n) {
        bool[] isntCel = new bool[n];
        for(int i = 0; i < n; i++){
            if(isntCel[i]) continue;
            for(int j = i+1; j < n; j++){
                if(isntCel[j]) continue;
                if(Knows(i, j)) {
                    isntCel[i] = true;
                    break;
                } else isntCel[j] = true;
            }
            if(!isntCel[i]) {
                for(int j = 0; j < i; j++) if(Knows(i, j)) return -1;
                for(int j = 0; j < n; j++) if(j != i && (!Knows(j, i))) return -1;
                return i;
            }
        }
        return -1;
    }
}
