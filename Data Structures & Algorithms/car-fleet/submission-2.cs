public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        
        var pair = new List<(int pos, double time)>();

        for(int i = 0; i < position.Length; i++){
            pair.Add((position[i], (double)(target - position[i])/speed[i]));
        }

        pair.Sort((p1, p2) => p2.pos.CompareTo(p1.pos));


       int res = 0;
       double prevTime = 0;

       foreach(var p in pair){
            if(p.time > prevTime){
                res++;
                prevTime = p.time;
            }
       }

        return res;
        
    }
}
