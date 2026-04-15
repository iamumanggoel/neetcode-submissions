public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rowSet = new List<HashSet<char>>();
        var colSet = new List<HashSet<char>>();
        var sqSet = new List<HashSet<char>>();

        for(int i = 0; i < 9; i++){
            rowSet.Add(new HashSet<char>());
            colSet.Add(new HashSet<char>());
            sqSet.Add(new HashSet<char>());
        }

        for(int row = 0; row < 9; row++){
            for(int col = 0; col < 9; col++){
                var val = board[row][col];
                
                if(val == '.')
                    continue;


                if(!rowSet[row].Add(val))
                    return false;

                if(!colSet[col].Add(val))
                    return false;
                
                int sqIndex = (row/3)*3 + (col/3);
                if(!sqSet[sqIndex].Add(val))
                    return false;
            }
        }

        return true;
    }
}
