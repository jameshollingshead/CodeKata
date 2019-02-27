using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBoard
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class QueryBoard
    {
        private int[,] board;
        private int boardSize = 256;

        public QueryBoard()
        {
            board = CreateBoard();
        }

        public int[,] GetBoard()
        {
            return board;
        }

        private int[,] CreateBoard()
        {
            return new int[boardSize, boardSize];
        }

        public void SetRow(int row, int value)
        {
            for (int i = 0; i < boardSize; i++)
            {
                board[row, i] = value;
            }
        }

        public void SetColumn(int column, int value)
        {
            for (int i = 0; i < boardSize; i++)
            {
                board[i, column] = value;
            }
        }

        public int GetSumOfColumn(int column)
        {
            int result = 0;

            for (int i = 0; i < boardSize; i++)
            {
                result += board[i, column];
            }

            return result;
        }

        public int GetSumOfRow(int row)
        {
            int result = 0;

            for (int i = 0; i < boardSize; i++)
            {
                result += board[row, i];
            }

            return result;
        }
    }
}
