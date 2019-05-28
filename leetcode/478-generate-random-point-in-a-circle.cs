//https://leetcode.com/problems/generate-random-point-in-a-circle/

//Polar system, be careful about "on" the circle vs. "in" the circle.


public class Solution {

    double Radius;
    double X;
    double Y;
    Random Rand;
    
    public Solution(double radius, double x_center, double y_center) {
        Radius = radius;
        X = x_center;
        Y = y_center;
        Rand = new Random();
    }
    
    public double[] RandPoint() {
        double r = Math.Sqrt(Rand.NextDouble()) * Radius;
        double next = Rand.NextDouble() * 2 * Math.PI;
        double x = r * Math.Cos(next) + X;
        double y = r * Math.Sin(next) + Y;
        return new double[2] {x, y};
    }
}
