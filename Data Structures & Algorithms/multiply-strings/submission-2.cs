public class Solution {
    public string Multiply(string num1, string num2) {
        
        long n1 = 0;

        foreach(char n in num1){
            n1 = n1*10 + (n- '0');
        }

        long n2 = 0;
        foreach(char n in num2){
            n2 = n2*10 + (n - '0');
        }

        return (n1*n2).ToString();
    }
}
