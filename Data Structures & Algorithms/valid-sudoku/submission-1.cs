public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rowset = new List<HashSet<char>>();
        var colset = new List<HashSet<char>>();
        var sqset = new List<HashSet<char>>();

        for(int i = 0; i < 9; i++){
            rowset.Add(new HashSet<char>());
            colset.Add(new HashSet<char>());
            sqset.Add(new HashSet<char>());
        }

        for(int row = 0; row < 9; row++){
            for(int col = 0; col < 9; col++){
                char val = board[row][col];

                if(val == '.')
                    continue;
                
                if(!rowset[row].Add(val))
                    return false;
                
                if(!colset[col].Add(val))
                    return false;

                int sqIdx = (row/3)*3 + (col/3);

                if(!sqset[sqIdx].Add(val))
                    return false;
            }
            
        }

        return true;

    }
}
