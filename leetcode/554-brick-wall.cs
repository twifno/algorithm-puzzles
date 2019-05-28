//https://leetcode.com/problems/brick-wall/

public class Solution {
    class Position {
        public int X;
        public int StartCount;
        public int EndCount;
        public Position(int x, int sc, int ec){
            X = x;
            StartCount = sc;
            EndCount = ec;
        }
    }
    
    public int LeastBricks(IList<IList<int>> wall) {
        Dictionary<int, Position> map = new Dictionary<int, Position>();
        foreach(IList<int> row in wall){
            int pos = 0;
            foreach(int b in row){
                if(!map.ContainsKey(pos)) map[pos] = new Position(pos, 0, 0);
                map[pos].StartCount += 1;
                pos += b;
                if(!map.ContainsKey(pos)) map[pos] = new Position(pos, 0, 0);
                map[pos].EndCount += 1;
            }
        }
        List<Position> p = new List<Position>(map.Values);
        p.Sort((x, y) => x.X.CompareTo(y.X));
        int count = 0;
        int min = wall.Count;
        for(int i = 0; i < p.Count; i++){
            count -= p[i].EndCount;
            if(i != 0 && i != p.Count-1) min = Math.Min(min, count);
            count += p[i].StartCount;
        }
        return min;
    }
}
