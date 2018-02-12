using WannaPlayChess.Common;
using WannaPlayChess.Figures.Contracts;

namespace WannaPlayChess.Figures
{
    public class Queen : ChessFigure, IFigure
    {
        public Queen(ChessColor color) 
            : base(color)
        {
        }
    }
}
