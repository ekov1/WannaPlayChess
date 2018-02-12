using WannaPlayChess.Common;
using WannaPlayChess.Figures.Contracts;

namespace WannaPlayChess.Players.Contracts
{
    public interface IPlayer
    {
        string Name { get; }

        ChessColor Color { get; }

        void AddFigure(IFigure figure);

        void RemoveFigure(IFigure figure);
    }
}
