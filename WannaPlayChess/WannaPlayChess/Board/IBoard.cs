using WannaPlayChess.Common;
using WannaPlayChess.Figures.Contracts;

namespace WannaPlayChess.Board
{
    public interface IBoard
    {
        int TotalRows { get; }

        int TotalCols { get; }

        void AddFigure(IFigure figure, Position position);

        void RemoveFigure(Position position);

        IFigure GetfigureAtPosition(Position position);
    }
}
