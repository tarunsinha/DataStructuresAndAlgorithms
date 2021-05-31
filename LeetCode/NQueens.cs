using System;
using System.Collections.Generic;
public class NQueen
{
    public static List<List<String>> SolveNQueens(int n)
    {
        var board = new List<List<String>>()
        {
            new List<String> { String.Empty, String.Empty, String.Empty, String.Empty},
            new List<String> { String.Empty, String.Empty, String.Empty, String.Empty},
            new List<String> { String.Empty, String.Empty, String.Empty, String.Empty},
            new List<String> { String.Empty, String.Empty, String.Empty, String.Empty},
        };
        SolveNQueens(board, 0, n);
        return board;
    }

    public static bool SolveNQueens(List<List<String>> board, int row, int n)
    {
        if (row == n) return true;

        for (int col = 0; col < n; col++)
        {
            if (isSafe(board, row, col, n) == true)
            {
                board[row][col] = "Q";
                if (SolveNQueens(board, row + 1, n) == true) return true;
            }
            board[row][col] = String.Empty;
        }
        return false;
    }

    private static bool isSafe(List<List<String>> board, int row, int col, int n)
    {
        int i, j;
        // Check upper row
        for (i = 0; i < row; i++)
        {
            if (board[i][col] == "Q")
                return false;
        }

        //upper diagonal
        for (i = row, j = col; i >= 0 &&
             j >= 0; i--, j--)
            if (board[i][j] == "Q")
                return false;
        // lower diagonal
        for (i = row, j = col; j >= 0 &&
                      i < n; i++, j--)
            if (board[i][j] == "Q")
                return false;

        return true;
    }
}