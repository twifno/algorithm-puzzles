//https://leetcode.com/problems/design-compressed-string-iterator/

public class StringIterator {
    char Current;
    int Remain;
    string Compressed;
    int next;
    
    public StringIterator(string compressedString) {
        Remain = 0;
        Compressed = compressedString;
        next = 0;
    }
    
    public char Next() {
        if(!HasNext()) return ' ';
        if(Remain > 0) {
            Remain -= 1;
            return Current;
        }
        Current = Compressed[next];
        int newNext = next+1;
        while(newNext < Compressed.Length && Compressed[newNext] >= '0' && Compressed[newNext] <= '9') newNext += 1;
        Remain = Int32.Parse(Compressed.Substring(next+1, newNext-next-1)) - 1;
        next = newNext;
        return Current;
    }
    
    public bool HasNext() {
        if(Remain > 0) return true;
        if(next < Compressed.Length) return true;
        return false;
    }
}

/**
 * Your StringIterator object will be instantiated and called as such:
 * StringIterator obj = new StringIterator(compressedString);
 * char param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */
