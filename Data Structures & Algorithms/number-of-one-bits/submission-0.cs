public class Solution {
    public int HammingWeight(uint n) {
        int count = 0;

        while(n != 0){
            n = n & (n-1); //removes the rightmost bit
            count++;

        }


        return count; 
    }
}
