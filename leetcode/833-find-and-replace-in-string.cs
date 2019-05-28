//https://leetcode.com/problems/find-and-replace-in-string/

public class Solution {
    class Replace {
        public int Index;
        public string Source;
        public string Target;
        public Replace(int i, string s, string t){
            Index = i;
            Source = s;
            Target = t;
        }
    }
    public string FindReplaceString(string S, int[] indexes, string[] sources, string[] targets) {
        int len = indexes.Length;
        Replace[] r = new Replace[len];
        for(int i = 0; i < len; i++){
            r[i] = new Replace(indexes[i], sources[i], targets[i]);
        }
        Array.Sort(r, (x, y) => y.Index.CompareTo(x.Index));
        foreach(Replace rep in r){
            if(S.IndexOf(rep.Source, rep.Index) == rep.Index) {
                S = S.Substring(0, rep.Index) + rep.Target + S.Substring(rep.Index+rep.Source.Length, S.Length-rep.Index-rep.Source.Length);
            }
        }
        return S;
    }
}
