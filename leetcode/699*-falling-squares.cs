//https://leetcode.com/problems/falling-squares/

//N^2 - checking overlap of each squares.
//There is better solutions

public class Solution {
    class Square { 
        public int Base;
        public int Left;
        public int Len;
        public Square(int b, int left, int len){
            Base = b;
            Left = left;
            Len = len;
        }
    }
    
    public IList<int> FallingSquares(int[,] positions) {
        List<int> res = new List<int>();
        List<Square> squares = new List<Square>();
        int max = 0;
        for(int i = 0; i < positions.GetLength(0); i++){
            int left = positions[i, 0];
            int len = positions[i, 1];
            Square sq = new Square(0, left, len);
            for(int j = 0; j < squares.Count; j++){
                if(Overlap(sq, squares[j])) sq.Base = Math.Max(sq.Base, squares[j].Base + squares[j].Len);
            }
            max = Math.Max(max, sq.Base+sq.Len);
            res.Add(max);
            squares.Add(sq);
        }
        return res;
    }
    
    private bool Overlap(Square sq1, Square sq2){
        if(sq1.Left <= sq2.Left && sq1.Left+sq1.Len > sq2.Left) return true;
        if(sq2.Left <= sq1.Left && sq2.Left+sq2.Len > sq1.Left) return true;
        return false;
    }
}
