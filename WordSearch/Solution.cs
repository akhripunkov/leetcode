namespace WordSearch;

public class Solution {
    public bool Exist(char[][] board, string word)
    {
        var hash = new HashSet<char>();
        int m = board.Length;
        int n = board[0].Length;
        foreach (var cols in board) 
        {
            foreach (var val in cols)
            {
                hash.Add(val);
            }
        }

        foreach (var ch in word)
        {
            if (!hash.Contains(ch))
                return false;
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (Exist(board, word, i, j, 0))
                {
                    return true;
                }
            }
        }
        
        return false;
        
        bool Exist(char[][] board, string word, int i, int j, int index)
        {
            if (index >= word.Length) {
                return true;
            }

            if (i < 0 || i >= m || j < 0 || j >= n || board[i][j] != word[index]) {
                return false;
            }

            char temp = board[i][j];
            board[i][j] = '1';
            
            bool found = Exist(board, word, i + 1, j, index + 1) ||
                         Exist(board, word, i - 1, j, index + 1) ||
                         Exist(board, word, i, j + 1, index + 1) ||
                         Exist(board, word, i, j - 1, index + 1);
            
            board[i][j] = temp;

            return found;
        }
    }

    
}