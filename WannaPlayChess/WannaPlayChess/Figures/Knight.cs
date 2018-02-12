using WannaPlayChess.Common;
using WannaPlayChess.Figures.Contracts;

namespace WannaPlayChess.Figures
{
    public class Knight : ChessFigure, IFigure
    {
        public Knight(ChessColor color)
            : base(color)
        {
        }
    }
}
