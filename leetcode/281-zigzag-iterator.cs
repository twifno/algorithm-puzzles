//https://leetcode.com/problems/zigzag-iterator/

//Use queue when there are n lists.

public class ZigzagIterator {

    IList<int> V1;
    IList<int> V2;
    int Pos1;
    int Pos2;
    
    public ZigzagIterator(IList<int> v1, IList<int> v2) {
        V1 = v1;
        V2 = v2;
        Pos1 = 0;
        Pos2 = 0;
    }

    public bool HasNext() {
        if(Pos1 < V1.Count || Pos2 < V2.Count) return true;
        return false;
    }

    public int Next() {
        if(Pos1 >= V1.Count) {
            int val = V2[Pos2];
            Pos2 += 1;
            return val;
        } else if(Pos2 >= V2.Count) {
            int val = V1[Pos1];
            Pos1 += 1;
            return val;
        } else if(Pos1 <= Pos2){
            int val = V1[Pos1];
            Pos1 += 1;
            return val;
        } else {
            int val = V2[Pos2];
            Pos2 += 1;
            return val;
        }
    }
}

/**
 * Your ZigzagIterator will be called like this:
 * ZigzagIterator i = new ZigzagIterator(v1, v2);
 * while (i.HasNext()) v[f()] = i.Next();
 */
