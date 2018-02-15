using System;
using WannaPlayChess.Common;
using WannaPlayChess.Figures.Contracts;

namespace WannaPlayChess.Board
{
    public class Board : IBoard
    {
        private IFigure[,] board;

        public Board(int rows = GlobalConstants.StandardGameBoardRows, int cols = GlobalConstants.StandardGameBoardRows)
        {
            this.TotalRows = rows;
            this.TotalCols = cols;
            this.board = new IFigure[rows, cols];
        }

        public int TotalRows { get; private set; }

        public int TotalCols { get; private set; }

        public IFigure GetfigureAtPosition(Position position)
        {
            int arrRow = this.GetArrayRow(position.Row);
            int arrCol = this.GetArrayCol(position.Col);

            return this.board[arrRow, arrCol];
        }

        public void AddFigure(IFigure figure, Position position)
        {
            ObjectValidator.CheckIfObjectIsNull(figure, GlobalErrormessages.NullFigureErrorMessage);

            this.CheckIfPositionIsValid(position);

            int arrayRow = GetArrayRow(position.Row);
            int arrayCol = GetArrayCol(position.Col);

            this.board[arrayRow, arrayCol] = figure;
        }

        public void RemoveFigure(Position position)
        {
            this.CheckIfPositionIsValid(position);

            int arrayRow = GetArrayRow(position.Row);
            int arrayCol = GetArrayCol(position.Col);

            this.board[arrayRow, arrayCol] = null;
        }

        private int GetArrayRow(int chessRow)
        {
            return this.TotalRows - chessRow;
        }

        private int GetArrayCol(char chessCol)
        {
            return chessCol - 'a';
        }

        private void CheckIfPositionIsValid(Position position)
        {
            if (position.Row < GlobalConstants.MinimumRowValue || GlobalConstants.MaximumRowValue < position.Row)
            {
                throw new IndexOutOfRangeException("Selected Row position is not valid");
            }

            if (position.Col < 'a' || position.Col > 'h')
            {
                throw new IndexOutOfRangeException("Selected Col position is not valid");
            }
        }
    }
}
