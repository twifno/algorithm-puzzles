//https://leetcode.com/problems/design-snake-game/

//Queue to remember the snake body
//HashSet to check collision.

public class SnakeGame {

    int Width;
    int Height;
    int[,] Food;
    int FoodIndex;
    int Row;
    int Column;
    Queue<string> Body;
    HashSet<string> HasBody;
    
    /** Initialize your data structure here.
        @param width - screen width
        @param height - screen height 
        @param food - A list of food positions
        E.g food = [[1,1], [1,0]] means the first food is positioned at [1,1], the second is at [1,0]. */
    public SnakeGame(int width, int height, int[,] food) {
        Width = width;
        Height = height;
        Food = food;
        FoodIndex = 0;
        Row = 0;
        Column = 0;
        Body = new Queue<string>();
        HasBody = new HashSet<string>();
        Body.Enqueue("0:0");
        HasBody.Add("0:0");
    }
    
    /** Moves the snake.
        @param direction - 'U' = Up, 'L' = Left, 'R' = Right, 'D' = Down 
        @return The game's score after the move. Return -1 if game over. 
        Game over when snake crosses the screen boundary or bites its body. */
    public int Move(string direction) {
        if(direction == "U") Row -= 1;
        else if(direction == "L") Column -= 1;
        else if(direction == "R") Column += 1;
        else if(direction == "D") Row += 1;
        
        if(Row < 0 || Row >= Height || Column < 0 || Column >= Width) return -1;
        string key = Row.ToString() + ":" + Column;
        if(FoodIndex >= Food.GetLength(0) || Food[FoodIndex, 0] != Row || Food[FoodIndex, 1] != Column) {
            HasBody.Remove(Body.Dequeue());
        } else {
            FoodIndex += 1;
        }
        if(HasBody.Contains(key)) return -1;
        Body.Enqueue(key);
        HasBody.Add(key);
        return Body.Count-1;
    }
}

/**
 * Your SnakeGame object will be instantiated and called as such:
 * SnakeGame obj = new SnakeGame(width, height, food);
 * int param_1 = obj.Move(direction);
 */
