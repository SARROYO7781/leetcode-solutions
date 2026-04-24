using System.Collections.Generic;

public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> seen = new HashSet<string>();

        for (int row = 0; row < 9; row++) {
            for (int col = 0; col < 9; col++) {
                char value = board[row][col];

                if (value == '.') {
                    continue;
                }

                string rowKey = value + " in row " + row;
                string colKey = value + " in col " + col;
                string boxKey = value + " in box " + (row / 3) + "-" + (col / 3);

                if (seen.Contains(rowKey) || seen.Contains(colKey) || seen.Contains(boxKey)) {
                    return false;
                }

                seen.Add(rowKey);
                seen.Add(colKey);
                seen.Add(boxKey);
            }
        }

        return true;
    }
}
