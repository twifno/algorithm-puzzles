//https://leetcode.com/problems/queue-reconstruction-by-height/

//Greedy, sort by height then sort by k

public class Solution {
    class Person {
        public int Height;
        public int K;
        public Person(int h, int k){
            Height = h;
            K = k;
        }
    }
    
    public int[,] ReconstructQueue(int[,] people) {
        Person[] p = new Person[people.GetLength(0)];
        for(int i = 0; i < p.Length; i++){
            p[i] = new Person(people[i,0], people[i,1]);
        }
        Array.Sort(p, (x,y) => (x.Height==y.Height)?(x.K.CompareTo(y.K)):(y.Height.CompareTo(x.Height)));
        List<Person> pl = new List<Person>();
        foreach(Person person in p){
            pl.Insert(person.K, person);
        }
        int[,] res = new int[p.Length,2];
        for(int i = 0; i < p.Length; i++){
            res[i, 0] = pl[i].Height;
            res[i, 1] = pl[i].K;
        }
        return res;
    }
}
