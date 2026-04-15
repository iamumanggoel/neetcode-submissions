public class Solution {
    public string Multiply(string num1, string num2) {
        
        long.TryParse(num1, out var n1);
        long.TryParse(num2, out var n2);

        return (n1*n2).ToString();
    }
}
