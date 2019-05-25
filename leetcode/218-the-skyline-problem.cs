//https://leetcode.com/problems/the-skyline-problem/

//Use priority queue to handle each point, O(nlogn)

public class Solution {
    class Critical: IComparable<Critical> {
        public int Pos;
        public bool Start;
        public int Height;
        public int Id;
        public Critical(int p, bool s, int h, int id){
            Pos = p;
            Start = s;
            Height = h;
            Id = id;
        }
        public int CompareTo(Critical o){
            if(Height != o.Height) return Height.CompareTo(o.Height);
            return Id.CompareTo(o.Id);
        }
    }
    
    public IList<int[]> GetSkyline(int[][] buildings) {
        List<Critical> list = new List<Critical>();
        for(int i = 0; i < buildings.Length; i++){
            int[] b = buildings[i];
            list.Add(new Critical(b[0], true, b[2], i));
            list.Add(new Critical(b[1], false, b[2], i));
        }
        list.Sort((x,y) =>x.Pos.CompareTo(y.Pos));
        List<int[]> res = new List<int[]>();
        SortedSet<Critical> q = new SortedSet<Critical>();
        int curH = 0;
        for(int i = 0; i < list.Count; i++){
            Critical c = list[i];
            if(c.Start){
                q.Add(c);
            } else {
                q.Remove(c);
            }
            if(i == list.Count-1 || c.Pos != list[i+1].Pos){
                int h = q.Count==0?0:q.Max.Height;
                if(curH != h) {
                    curH = h;
                    res.Add(new int[2]{c.Pos, h});
                }
            }
        }
        return res;
    }
}
