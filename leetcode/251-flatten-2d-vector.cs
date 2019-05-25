//https://leetcode.com/problems/flatten-2d-vector/

public class Vector2D {
    int[][] v;
    int i;
    int j;
    
    public Vector2D(int[][] v) {
        this.v = v;
        i = 0;
        j = 0;
        while(i < v.Length && v[i].Length == 0) i+= 1;
    }
    
    public int Next() {
        int next = v[i][j];
        if(j < v[i].Length-1) j += 1;
        else{
            j = 0;
            i += 1;
            while(i < v.Length && v[i].Length == 0) i+= 1;
        }
        return next;
    }
    
    public bool HasNext() {
        if(i >= v.Length) return false;
        return true;
    }
}

/**
 * Your Vector2D object will be instantiated and called as such:
 * Vector2D obj = new Vector2D(v);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */
