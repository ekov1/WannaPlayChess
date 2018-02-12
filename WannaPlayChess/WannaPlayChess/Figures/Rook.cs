using WannaPlayChess.Common;
using WannaPlayChess.Figures.Contracts;

namespace WannaPlayChess.Figures
{
    public class Rook : ChessFigure, IFigure
    {
        public Rook(ChessColor color) 
            : base(color)
        {
        }
    }
}
