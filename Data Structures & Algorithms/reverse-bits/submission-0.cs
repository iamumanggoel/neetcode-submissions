public class Solution {
    public uint ReverseBits(uint n) {
        uint res = 0;

        for(int i = 0; i < 32; i++){
            uint iBit = (n >> i) & 1;   // 100101000'1'

            res = res | (iBit << (31 - i));    
        }

        return res;
    }
}
