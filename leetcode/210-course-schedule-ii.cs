//https://leetcode.com/problems/course-schedule-ii/

public class Solution {
    public int[] FindOrder(int numCourses, int[,] prerequisites) {
        Dictionary<int, int> preCounts = new Dictionary<int, int>();
        Dictionary<int, List<int>> pres = new Dictionary<int, List<int>>();
        
        for(int i = 0; i < prerequisites.GetLength(0); i++){
            int course = prerequisites[i, 0];
            int pre = prerequisites[i, 1];
            if(preCounts.ContainsKey(course)) preCounts[course] += 1;
            else preCounts[course] = 1;
            if(!pres.ContainsKey(pre)) pres[pre] = new List<int>();
            pres[pre].Add(course);
        }
        
        Queue<int> q = new Queue<int>();
        for(int i = 0; i < numCourses; i++){
            if(!preCounts.ContainsKey(i)) q.Enqueue(i);
        }
        int count = 0;
        int[] res = new int[numCourses];
        while(q.Count > 0){
            int node = q.Dequeue();
            res[count] = node;
            count += 1;
            if(pres.ContainsKey(node)){
                foreach(int n in pres[node]){
                    preCounts[n] -= 1;
                    if(preCounts[n] == 0) q.Enqueue(n);
                }
            }
        }
        if(count == numCourses) return res;
        else return new int[0];
    }
}
