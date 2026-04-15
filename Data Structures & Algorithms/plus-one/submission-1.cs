public class Solution {
    public int[] PlusOne(int[] digits) {
        int carry = 0;
        for(int i = digits.Length - 1; i >=0; i--){



            if(i == digits.Length - 1){
                int num = digits[i] + 1;
                digits[i] = num % 10;
                carry = num / 10;
                continue;
            }

            if(carry > 0){
                int num = digits[i] + carry;
                digits[i] = num % 10;
                carry = num / 10;
            }
        }

        if(carry > 0){
            var res = new int[digits.Length + 1];
            res[0] = carry;
            for(int i = 0; i < digits.Length; i++){
                res[i+1] = digits[i];
            }

            return res;
        }
        return digits;
    }
}
