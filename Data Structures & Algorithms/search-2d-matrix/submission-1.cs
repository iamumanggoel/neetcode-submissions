public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        
        int l = 0, r = (matrix.Length * matrix[0].Length) - 1;

        while(l <= r){
            var mid = l + (r-l)/2;
            var rowIdx = mid / matrix[0].Length;
            var colIdx = mid % matrix[0].Length;
            var valueToCheck = matrix[rowIdx][colIdx];
            if(valueToCheck < target){
                l++;
            }
            else if(valueToCheck > target){
                r--;
            }
            else{
                return true;
            }
            
        }

        return false;
    }
}
